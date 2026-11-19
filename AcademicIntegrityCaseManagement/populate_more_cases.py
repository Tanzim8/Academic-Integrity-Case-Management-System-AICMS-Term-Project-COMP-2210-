
from services.records import create_ed_case

sample_cases = [
    {
        "student_id": "T10000001",
        "faculty_id": "F1001",
        "term": "Fall 2026",
        "assignment_number": "Assignment 1",
        "ed_violation_description": "Uncredited use of online code",
        "violation_date": "2026-09-22"
    },
    {
        "student_id": "T10000002",
        "faculty_id": "F1002",
        "term": "Fall 2026",
        "assignment_number": "Midterm",
        "ed_violation_description": "Unauthorized reference materials",
        "violation_date": "2026-10-14"
    },
    {
        "student_id": "T10000003",
        "faculty_id": "F1003",
        "term": "Fall 2026",
        "assignment_number": "Lab 4",
        "ed_violation_description": "Copied laboratory report",
        "violation_date": "2026-10-19"
    },
    {
        "student_id": "T10000004",
        "faculty_id": "F1001",
        "term": "Fall 2026",
        "assignment_number": "Project 2",
        "ed_violation_description": "Unauthorized collaboration",
        "violation_date": "2026-11-03"
    },
    {
        "student_id": "T10000005",
        "faculty_id": "F1002",
        "term": "Fall 2026",
        "assignment_number": "Assignment 5",
        "ed_violation_description": "Improper citation of sources",
        "violation_date": "2026-11-08"
    },
    {
        "student_id": "T10000001",
        "faculty_id": "F1003",
        "term": "Winter 2027",
        "assignment_number": "Assignment 2",
        "ed_violation_description": "Unapproved use of generative AI",
        "violation_date": "2027-02-10"
    },
    {
        "student_id": "T10000002",
        "faculty_id": "F1001",
        "term": "Winter 2027",
        "assignment_number": "Final Project",
        "ed_violation_description": "Duplicated project submission",
        "violation_date": "2027-03-18"
    },
    {
        "student_id": "T10000003",
        "faculty_id": "F1002",
        "term": "Winter 2027",
        "assignment_number": "Quiz 3",
        "ed_violation_description": "Unauthorized communication",
        "violation_date": "2027-02-24"
    },
    {
        "student_id": "T10000004",
        "faculty_id": "F1003",
        "term": "Winter 2027",
        "assignment_number": "Assignment 3",
        "ed_violation_description": "Uncredited external assistance",
        "violation_date": "2027-03-05"
    },
    {
        "student_id": "T10000005",
        "faculty_id": "F1001",
        "term": "Winter 2027",
        "assignment_number": "Lab 6",
        "ed_violation_description": "Unauthorized sharing of solutions",
        "violation_date": "2027-03-12"
    }
]

for case in sample_cases:
    case_id = create_ed_case(case)
    print(
        "Created case:", case_id,
        "| Student:", case["student_id"],
        "| Faculty:", case["faculty_id"]
    )

print("Additional cases created successfully!")
