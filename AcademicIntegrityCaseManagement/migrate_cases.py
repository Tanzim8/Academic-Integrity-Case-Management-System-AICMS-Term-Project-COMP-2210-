import sqlite3

connection = sqlite3.connect("data/cases.db")
cursor = connection.cursor()

cursor.execute("""
    INSERT OR IGNORE INTO ed_case_acknowledgements(case_id)
    SELECT case_id FROM ed_case_info
""")

cursor.execute("""
    INSERT OR IGNORE INTO ed_case_reviews(case_id)
    SELECT case_id FROM ed_case_info
""")

connection.commit()
connection.close()

print("Existing cases updated successfully!")