# Academic-Integrity-Case-Management-System-AICMS-Term-Project-COMP-2210-
ACIMS is the term project I have built with my partner Sapnil Shuva for COMP 2210 course in Thompson Rivers University. 

So far We have managed to complete he part - 1 the backend part of the project using python and sqlite3. 

This application is mainly designed to manage academic integrity case records based on Academic INtegrity Case Report form. This app allows user to create, search, see, update, delete case records using a command line interface.

Techologies used - 
1. Python - App logic and user interaction
2. SQLite3 - Database for storing case records
3. Command-Line Interface(CLI) - Menu-based user interaction

Features: 
1. Create Case
2. Search Case (Searcing cases based on unique record id)
3. Display Cases
4. Update Cases (Updating specific fields of a case)
5. Delete Cases (Deleting cases based on unique record id)
6. Input validation (Ensures user inputs the right values in the right fields)

Database: 
This app uses SQLite to store records and the informations are saved in data/cases.db

Project Structure: 

AcademicIntegrityCaseManagement/
├── main.py
├── services/
│   ├── __init__.py
│   └── records.py
├── data/
│   └── cases.db
├── assets/
│   └── case_report_template.pdf
└── README.md

How to run: 
1. Python 3.10 or later installed
2. Open a terminal in the projects root directory
3. Run the following command: python3 main.py
4. The app will show 6 options
5. Select an option and follow instructions in the terminal

Note: The data directory must exist before running the application. The database table is initialized automatically if it does not already exist.

App Functions: 

The database operations are implemented in services/records.py:

initialize_database()

create_case(case_info)

search_case(field, value)

display_all_cases()

update_case(record_id, field, new_value)

delete_case(record_id)

The main.py file handles user input, menu navigation, and interaction with the database functions.

Course Info: 
Course: COMP 2210 - Programming Methods
Institution: Thompson River University
Project: Academic Integrity Case Management System
Submission: Part 1
Date: November 4, 2026

Contributers: Group 13
1. M. Tanzim Rahman
   ID - T00716893
   Tru Email - t00716893@mytru.ca
2. Sapnil Shuva
   ID - T00726132
   Tru Email - t00726132@mytru.ca


