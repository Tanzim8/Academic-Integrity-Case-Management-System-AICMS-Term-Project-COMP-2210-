import sqlite3

def initialize_database():
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute("""
        CREATE TABLE IF NOT EXISTS cases(
            record_id INTEGER PRIMARY KEY AUTOINCREMENT,
            student_name TEXT NOT NULL,
            student_number TEXT NOT NULL,
            student_email TEXT,
            faculty_name TEXT,
            course TEXT,
            report_date TEXT
            )
            """
            )
    connection.commit()
    connection.close()
def create_case(case_info): 
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        """
        INSERT INTO cases(
            student_name,
            student_number,
            student_email,
            faculty_name,
            course,
            report_date
            )VALUES(?,?,?,?,?,?)
        """,
        (
            case_info["student_name"],
            case_info["student_number"],
            case_info["student_email"],
            case_info["faculty_name"],
            case_info["course"],
            case_info["report_date"]
        )
    )
    connection.commit()
    connection.close()

def search_case(field, value):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    allowed_fields = [
        "record_id",
        "student_name",
        "student_number",
        "faculty_name"
    ]

    if field not in allowed_fields:
        connection.close()
        return[]

    cursor.execute(
        f"SELECT * FROM cases WHERE {field}= ?",
        (value,)
    )
    records = cursor.fetchall()
    connection.close()
    return records

def display_all_cases():
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        "SELECT * FROM cases"
    )
    records = cursor.fetchall()
    connection.close()
    return records

def delete_case(record_id): 
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        "DELETE FROM cases WHERE record_id=?",
    (record_id,)
    )
    connection.commit()
    connection.close()

def update_case(record_id, field, new_value):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        "UPDATE cases SET field = ? WHERE record_id = ?",
        (new_value,record_id)
    )