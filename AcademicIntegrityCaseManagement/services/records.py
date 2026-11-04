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
            report_date TEXT,
            assignment_number TEXT,
            department TEXT,
            semester TEXT,
            violation_description TEXT,
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
            chair_agrees INTEGER,
            chair_comments TEXT,
            chair_signature TEXT,
            chair_name TEXT,
            chair_date TEXT,

            dean_agrees INTEGER,
            dean_comments TEXT,
            dean_signature TEXT,
            dean_name TEXT,
            dean_date TEXT,

            faculty_comments TEXT,

            student_comments TEXT
            )
            """
            )
    connection.commit()
    connection.close()


def create_case(case_info): 
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    fields = list(case_info.keys())
    values = list(case_info.values())

    columns = ", ".join(fields)
    placeholders = ", ".join(["?"] * len(fields))

    cursor.execute(
        f"INSERT INTO cases({columns}) VALUES ({placeholders})",
        values
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


def update_case(record_id, field, new_value):
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()
    allowed_fields=[
        "student_name",
        "student_number",
        "student_email",
        "faculty_name",
        "course",
        "report_date",
        "assignment_number",
        "department",
        "semester",
        "violation_description",
        "support_person_advised",
        "written_statement_advised",
        "faculty_signature",
        "faculty_signature_date",
        "student_acknowledgement_name",
        "evidence_reviewed",
        "mytru_email",
        "student_signature",
        "student_signature_date",
        "faculty_followup_signature",
        "faculty_followup_name",
        "faculty_followup_date",
        
        # Page 3 - Chair and Dean Review
        "chair_agrees",
        "chair_comments",
        "chair_signature",
        "chair_name",
        "chair_date",
        "dean_agrees",
        "dean_comments",
        "dean_signature",
        "dean_name",
        "dean_date",

        # Pages 4 and 5 - Additional Comments
        "faculty_comments",
        "student_comments"
        
    ]

    if field not in allowed_fields:
        connection.close()
        return False
    
    boolean_fields = [
        "support_person_advised",
        "written_statement_advised",
        "evidence_reviewed",
        "chair_agrees",
        "dean_agrees"
    ]

    if field in boolean_fields:
        answer = str(new_value).strip().lower()

        if answer in ("y", "yes", "1"):
            new_value = 1
        elif answer in ("n", "no", "0"):
            new_value = 0
        else:
            connection.close()
            return False
        
    cursor.execute(
        f"UPDATE cases SET {field} = ? WHERE record_id = ?",
        (new_value,record_id)
    )

    updated = cursor.rowcount >0
    connection.commit()
    connection.close()
    return updated

def delete_case(record_id): 
    connection = sqlite3.connect("data/cases.db")
    cursor = connection.cursor()

    cursor.execute(
        "DELETE FROM cases WHERE record_id=?",
    (record_id,)
    )

    deleted = cursor.rowcount >0
    connection.commit()
    connection.close()

    return deleted