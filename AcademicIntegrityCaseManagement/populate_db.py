from services.records import create_ed_case

sample_cases = [
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2026",
        "assignment_number": "Assignment 2",
        "ed_violation_description": "Unauthorized collaboration",
        "violation_date": "2026-10-15"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2026",
        "assignment_number": "Assignment 4",
        "ed_violation_description": "Copied code from another student",
        "violation_date": "2026-11-02"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2026",
        "assignment_number": "Midterm Exam",
        "ed_violation_description": "Unauthorized use of notes",
        "violation_date": "2026-10-25"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Winter 2027",
        "assignment_number": "Project 1",
        "ed_violation_description": "Improper citation of sources",
        "violation_date": "2027-01-18"
    },

    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2026",
        "assignment_number": "Assignment 6",
        "ed_violation_description": "Plagiarism in research paper",
        "violation_date": "2026-11-10"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2026",
        "assignment_number": "Lab 3",
        "ed_violation_description": "Unauthorized sharing of solutions",
        "violation_date": "2026-10-08"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Winter 2027",
        "assignment_number": "Assignment 1",
        "ed_violation_description": "Uncredited use of online material",
        "violation_date": "2027-01-14"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Winter 2027",
        "assignment_number": "Lab 5",
        "ed_violation_description": "Unauthorized collaboration on lab work",
        "violation_date": "2027-02-11"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Winter 2027",
        "assignment_number": "Midterm Exam",
        "ed_violation_description": "Use of prohibited reference materials",
        "violation_date": "2027-02-20"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Winter 2027",
        "assignment_number": "Assignment 3",
        "ed_violation_description": "Improper attribution of source code",
        "violation_date": "2027-03-04"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2025",
        "assignment_number": "Final Project",
        "ed_violation_description": "Submission of duplicated project work",
        "violation_date": "2025-12-02"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2025",
        "assignment_number": "Assignment 4",
        "ed_violation_description": "Unapproved use of generative AI",
        "violation_date": "2025-11-17"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Summer 2026",
        "assignment_number": "Quiz 2",
        "ed_violation_description": "Unauthorized communication during assessment",
        "violation_date": "2026-06-21"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Summer 2026",
        "assignment_number": "Assignment 2",
        "ed_violation_description": "Uncredited use of another student's work",
        "violation_date": "2026-07-09"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Fall 2026",
        "assignment_number": "Quiz 4",
        "ed_violation_description": "Use of unauthorized electronic resources",
        "violation_date": "2026-11-12"
    },
    {
        "student_id": "T00716893",
        "faculty_id": "F001",
        "term": "Winter 2027",
        "assignment_number": "Final Project",
        "ed_violation_description": "Improper citation in final submission",
        "violation_date": "2027-04-08"
    }

]

for case in sample_cases:
    case_id = create_ed_case(case)
    print("Created case ID:", case_id)

print("Database populated successfully!")
