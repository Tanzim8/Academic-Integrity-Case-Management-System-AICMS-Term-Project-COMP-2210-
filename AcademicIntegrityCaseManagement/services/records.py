import sqlite3
import bcrypt


#creating database table if doesnt exists
#defining the fields to store academic integrity case reports
def initialize_database():
    connection = sqlite3.connect("data/cases.db")
    connection.execute("PRAGMA foreign_keys = ON")
    cursor = connection.cursor()

    #Table - 1 (users)
    # cursor.execute("DROP TABLE IF EXISTS users")
    cursor.execute(
        """
        CREATE TABLE IF NOT EXISTS users (
            user_id VARCHAR(10) PRIMARY KEY,
            name VARCHAR(50),
            email VARCHAR(25),
            department VARCHAR(35),
            user_type TEXT,
            username TEXT UNIQUE NOT NULL,
            password_hash TEXT NOT NULL
            )
        
        """
    )

    #Table - 2 (Case Info)
    cursor.execute("""
        CREATE TABLE IF NOT EXISTS ed_case_info(
            case_id INTEGER PRIMARY KEY AUTOINCREMENT,
            student_id VARCHAR(10),
            faculty_id VARCHAR(10),
            chair_id VARCHAR(10),
            dean_id VARCHAR(10),
            term TEXT,
            assignment_number VARCHAR(10),
            ed_violation_description TEXT,
            violation_date TEXT,

            FOREIGN KEY (student_id) REFERENCES users(user_id),
            FOREIGN KEY (faculty_id) REFERENCES users(user_id),
            FOREIGN KEY (chair_id) REFERENCES users(user_id),
            FOREIGN KEY (dean_id) REFERENCES users(user_id)
            )
    """)

    #Table - 3 (Case Comments)
    cursor.execute("""
        CREATE TABLE IF NOT EXISTS ed_case_comments (
            case_id INTEGER PRIMARY KEY,
            chair_comments TEXT,
            dean_comments TEXT,
            faculty_comments TEXT,
            student_comments TEXT,
            
            FOREIGN KEY (case_id) REFERENCES ed_case_info(case_id))
    """)


    # Table 4 - Case Acknowledgements
    cursor.execute("""
        CREATE TABLE IF NOT EXISTS ed_case_acknowledgements (
            case_id INTEGER PRIMARY KEY,

            support_person_advised INTEGER,
            written_statement_advised INTEGER,

            faculty_signature TEXT,
            faculty_signature_date TEXT,

            student_acknowledgement_name TEXT,
            evidence_reviewed INTEGER,
            mytru_email TEXT,
            student_signature TEXT,
            student_signature_date TEXT,

            faculty_followup_signature TEXT,
            faculty_followup_name TEXT,
            faculty_followup_date TEXT,

            FOREIGN KEY (case_id)
                REFERENCES ed_case_info(case_id)
        )
    """)

    # Table 5 - Chair and Dean Reviews
    cursor.execute("""
        CREATE TABLE IF NOT EXISTS ed_case_reviews (
            case_id INTEGER PRIMARY KEY,

            chair_agrees INTEGER,
            chair_signature TEXT,
            chair_date TEXT,

            dean_agrees INTEGER,
            dean_signature TEXT,
            dean_date TEXT,

            FOREIGN KEY (case_id)
                REFERENCES ed_case_info(case_id)
        )
    """)

    # Add missing columns to existing case information table
    cursor.execute("PRAGMA table_info(ed_case_info)")
    existing_columns = {
        column[1] for column in cursor.fetchall()
    }

    new_columns = {
        "course": "TEXT",
        "report_date": "TEXT",
        "case_department": "TEXT",
        "recommended_sanction": "TEXT"
    }

    for column_name, column_type in new_columns.items():
        if column_name not in existing_columns:
            cursor.execute(
                f"ALTER TABLE ed_case_info "
                f"ADD COLUMN {column_name} {column_type}"
            )

    connection.commit()

    cursor.execute("SELECT name FROM sqlite_master WHERE type = 'table'")
    print(cursor.fetchall())
    connection.close()



#Method to register an user in the system
def register_user(user_id, name, email, department, user_type, username, password):
    if user_type not in ["Student", "Faculty"]:
        print("Registration denied! Invalid role.")
        return False
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    password_hash = bcrypt.hashpw(
        password.encode("utf-8"),
        bcrypt.gensalt()
    ).decode("utf-8")
    cursor.execute("""
        INSERT INTO users(user_id,name,email,department,user_type, username, password_hash)
        VALUES(?, ?, ?, ?, ?, ?, ?)
        """,
        (user_id, name, email, department, user_type,username, password_hash))
    connection.commit()
    connection.close()
    return True


#function to login
def login_user(username, password):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute("""
        SELECT * FROM users WHERE username = ?""",(username,))
    record = cursor.fetchone()
    connection.close()
    if record is None:
        return False
    else:
        if bcrypt.checkpw(
            password.encode("utf-8"),
            record[6].encode("utf-8")
        ):
            return record
        else:
            return False
    # connection.close()


def create_ed_case_old(case_info): 
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    student_id = case_info["student_id"]
    faculty_id = case_info["faculty_id"]
    term = case_info["term"]
    chair_id = case_info.get("chair_id")
    dean_id = case_info.get("dean_id")
    assignment_number = case_info["assignment_number"]
    ed_violation_description = case_info["ed_violation_description"]
    violation_date = case_info["violation_date"]

    cursor.execute("""
            INSERT INTO ed_case_info(
            student_id,
            faculty_id,
            term,
            chair_id,
            dean_id,
            assignment_number,
            ed_violation_description,
            violation_date)
            values(?,?,?,?,?,?,?,?)""",
            (
                student_id,
                faculty_id,
                term,
                chair_id,
                dean_id,
                assignment_number,
                ed_violation_description,
                violation_date
                ))
    case_id = cursor.lastrowid
    cursor.execute("""
            INSERT INTO ed_case_comments(case_id)
            VALUES(?)""",(case_id,))

    cursor.execute("""
        INSERT INTO ed_case_acknowledgements(case_id)
        VALUES(?)
    """, (case_id,))

    cursor.execute("""
        INSERT INTO ed_case_reviews(case_id)
        VALUES(?)
    """, (case_id,))
    connection.commit()
    connection.close()
    return case_id

def create_ed_case(case_info):
    connection = sqlite3.connect("data/cases.db")
    connection.execute("PRAGMA foreign_keys = ON")
    cursor = connection.cursor()

    try:
        # Validate student
        cursor.execute("""
            SELECT user_id FROM users
            WHERE user_id = ? AND user_type = 'Student'
        """, (case_info["student_id"],))

        if cursor.fetchone() is None:
            raise ValueError("Student ID does not exist.")

        # Validate faculty
        cursor.execute("""
            SELECT user_id FROM users
            WHERE user_id = ? AND user_type = 'Faculty'
        """, (case_info["faculty_id"],))

        if cursor.fetchone() is None:
            raise ValueError("Faculty ID does not exist.")

        # TABLE 1 - Main case information
        cursor.execute("""
            INSERT INTO ed_case_info (
                student_id,
                faculty_id,
                chair_id,
                dean_id,
                term,
                assignment_number,
                ed_violation_description,
                violation_date,
                course,
                report_date,
                case_department,
                recommended_sanction
            )
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)
        """, (
            case_info["student_id"],
            case_info["faculty_id"],
            case_info.get("chair_id") or None,
            case_info.get("dean_id") or None,
            case_info["term"],
            case_info["assignment_number"],
            case_info["ed_violation_description"],
            case_info.get("violation_date"),
            case_info.get("course"),
            case_info.get("report_date"),
            case_info.get("case_department"),
            case_info.get("recommended_sanction")
        ))

        case_id = cursor.lastrowid

        # TABLE 2 - Acknowledgements and signatures
        cursor.execute("""
            INSERT INTO ed_case_acknowledgements (
                case_id,
                support_person_advised,
                written_statement_advised,
                faculty_signature,
                faculty_signature_date,
                student_acknowledgement_name,
                evidence_reviewed,
                mytru_email,
                student_signature,
                student_signature_date,
                faculty_followup_signature,
                faculty_followup_name,
                faculty_followup_date
            )
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)
        """, (
            case_id,
            case_info.get("support_person_advised"),
            case_info.get("written_statement_advised"),
            case_info.get("faculty_signature"),
            case_info.get("faculty_signature_date"),
            case_info.get("student_acknowledgement_name"),
            case_info.get("evidence_reviewed"),
            case_info.get("mytru_email"),
            case_info.get("student_signature"),
            case_info.get("student_signature_date"),
            case_info.get("faculty_followup_signature"),
            case_info.get("faculty_followup_name"),
            case_info.get("faculty_followup_date")
        ))

        # TABLE 3 - Chair and Dean reviews
        cursor.execute("""
            INSERT INTO ed_case_reviews (
                case_id,
                chair_agrees,
                chair_signature,
                chair_date,
                dean_agrees,
                dean_signature,
                dean_date
            )
            VALUES (?, ?, ?, ?, ?, ?, ?)
        """, (
            case_id,
            case_info.get("chair_agrees"),
            case_info.get("chair_signature"),
            case_info.get("chair_date"),
            case_info.get("dean_agrees"),
            case_info.get("dean_signature"),
            case_info.get("dean_date")
        ))

        # TABLE 4 - Additional comments
        cursor.execute("""
            INSERT INTO ed_case_comments (
                case_id,
                chair_comments,
                dean_comments,
                faculty_comments,
                student_comments
            )
            VALUES (?, ?, ?, ?, ?)
        """, (
            case_id,
            case_info.get("chair_comments"),
            case_info.get("dean_comments"),
            case_info.get("faculty_comments"),
            case_info.get("student_comments")
        ))

        connection.commit()
        return case_id

    except Exception:
        connection.rollback()
        raise

    finally:
        connection.close()

def search_ed_case(case_id): 
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        """
        SELECT ed_case_info.*,
        ed_case_comments.chair_comments,
        ed_case_comments.dean_comments,
        ed_case_comments.faculty_comments,
        ed_case_comments.student_comments
        FROM ed_case_info 
        LEFT JOIN ed_case_comments
        ON ed_case_info.case_id = ed_case_comments.case_id
        WHERE ed_case_info.case_id = ?
        """,(case_id,)
    )

    record = cursor.fetchone()
    connection.close()

    return record


def update_ed_case(case_id, field, new_value):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    allowed_fields = [
        "term",
        "assignment_number",
        "ed_violation_description"
    ]
    if field not in allowed_fields:
        print("Invalid field! Update denied")
        connection.close()
        return False
    cursor.execute(
        f"UPDATE ed_case_info SET {field} = ? WHERE case_id = ?",(new_value, case_id)
    )

    updated = cursor.rowcount > 0
    connection.commit()
    connection.close()
    return updated

def update_ed_comments(case_id, field, new_value):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    allowed_fields = [
        "chair_comments",
        "dean_comments",
        "faculty_comments",
        "student_comments"
    ]

    if field not in allowed_fields: 
        print("Invalid field! Update denied.")
        connection.close()
        return False
    cursor.execute(
        f"UPDATE ed_case_comments SET {field} = ? WHERE case_id = ?",(new_value,case_id)
    )

    updated = cursor.rowcount > 0

    connection.commit()
    connection.close()
    return updated

def delete_ed_case(case_id):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        "DELETE FROM ed_case_comments WHERE case_id = ?",(case_id,)
    )
    cursor.execute(
    "DELETE FROM ed_case_acknowledgements WHERE case_id = ?",
    (case_id,)
)

    cursor.execute(
    "DELETE FROM ed_case_reviews WHERE case_id = ?",
    (case_id,)
)
    cursor.execute(
        "DELETE FROM ed_case_info WHERE case_id = ?",(case_id,))

    deleted = cursor.rowcount > 0


    connection.commit()
    connection.close()

    return deleted

def search_student_cases(student_id):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        "SELECT * FROM ed_case_info WHERE student_id = ?",(student_id,)
    )
    records = cursor.fetchall()

    connection.close()
    return records

def search_faculty_cases(faculty_id):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        "SELECT case_id, student_id, term, assignment_number, ed_violation_description, violation_date FROM ed_case_info WHERE faculty_id = ?",(faculty_id,)
    )
    records = cursor.fetchall()

    connection.close()
    return records

def get_full_case(case_id):
    connection = sqlite3.connect("data/cases.db")
    connection.row_factory = sqlite3.Row  # This allows us to access columns by name
    cursor = connection.cursor()
    cursor.execute(
        """
        SELECT ed_case_info.*,
        student.name AS student_name,
        student.email AS student_email,
        faculty.name AS faculty_name,
        ed_case_comments.chair_comments,
        ed_case_comments.dean_comments,
        ed_case_comments.faculty_comments,
        ed_case_comments.student_comments,
        ed_case_acknowledgements.support_person_advised,
        ed_case_acknowledgements.written_statement_advised,
        ed_case_acknowledgements.faculty_signature,
        ed_case_acknowledgements.faculty_signature_date,
        ed_case_acknowledgements.student_acknowledgement_name,
        ed_case_acknowledgements.evidence_reviewed,
        ed_case_acknowledgements.mytru_email,
        ed_case_acknowledgements.student_signature,
        ed_case_acknowledgements.student_signature_date,
        ed_case_acknowledgements.faculty_followup_signature,
        ed_case_acknowledgements.faculty_followup_name,
        ed_case_acknowledgements.faculty_followup_date,
        ed_case_reviews.chair_agrees,
        ed_case_reviews.chair_signature,
        ed_case_reviews.chair_date,
        ed_case_reviews.dean_agrees,
        ed_case_reviews.dean_signature,
        ed_case_reviews.dean_date
        FROM ed_case_info
        LEFT JOIN ed_case_comments ON ed_case_info.case_id = ed_case_comments.case_id
        LEFT JOIN ed_case_acknowledgements ON ed_case_info.case_id = ed_case_acknowledgements.case_id
        LEFT JOIN ed_case_reviews ON ed_case_info.case_id = ed_case_reviews.case_id
        LEFT JOIN users AS student
        ON ed_case_info.student_id = student.user_id
        LEFT JOIN users AS faculty
        ON ed_case_info.faculty_id = faculty.user_id
                WHERE ed_case_info.case_id = ?
        """, (case_id,)
    )
    record = cursor.fetchone()
    connection.close()
    return dict(record) if record else None

def update_full_case(case_id, faculty_id,case_info):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    try:
        cursor.execute(
            """
            SELECT case_id FROM ed_case_info
            WHERE case_id = ? AND faculty_id = ?
            """,
            (case_id, faculty_id)
    )

        if cursor.fetchone() is None:
            return False

        cursor.execute(
            """
            UPDATE ed_case_info
            SET course = ?,
                term = ?,
                assignment_number = ?,
                case_department = ?,
                report_date = ?,
                violation_date = ?,
                ed_violation_description = ?
            WHERE case_id = ?
            """,
            (
                case_info["course"],
                case_info["term"],
                case_info["assignment_number"],
                case_info["case_department"],
                case_info["report_date"],
                case_info["violation_date"],
                case_info["ed_violation_description"],
                case_id
            )
        )

        if cursor.rowcount == 0:
            connection.rollback()
            return False

        cursor.execute(
            """
            UPDATE ed_case_comments
            SET faculty_comments = ?
            WHERE case_id = ?
            """,
            (
                case_info["faculty_comments"],
                case_id
            )
        )

        cursor.execute(
            """
            UPDATE ed_case_acknowledgements
            SET support_person_advised = ?,
                written_statement_advised = ?,
                faculty_signature = ?,
                faculty_signature_date = ?,
                faculty_followup_name = ?,
                faculty_followup_signature = ?,
                faculty_followup_date = ?
            WHERE case_id = ?
            """,
            (
                case_info["support_person_advised"],
                case_info["written_statement_advised"],
                case_info["faculty_signature"],
                case_info["faculty_signature_date"],
                case_info["faculty_followup_name"],
                case_info["faculty_followup_signature"],
                case_info["faculty_followup_date"],
                case_id
            )
        )

        connection.commit()
        return True

    except Exception:
        connection.rollback()
        raise

    finally:
        connection.close()




