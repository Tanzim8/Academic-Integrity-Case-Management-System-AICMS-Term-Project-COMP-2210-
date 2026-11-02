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
            )VALUES(stundent_name,student_number,student_email,faculty_name,course,report_date)
        """
    )
    connection.commit()
    connection.close()