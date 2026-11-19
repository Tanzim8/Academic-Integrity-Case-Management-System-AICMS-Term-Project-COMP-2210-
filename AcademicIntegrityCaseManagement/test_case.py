# from services.records import create_ed_case

# case_info = {
#     "student_id": "T00716893",
#     "faculty_id": "F001",
#     "term": "Fall 2026",
#     "assignment_number": "Assignment 5",
#     "ed_violation_description": "Unauthorized collaboration",
#     "violation_date": "2026-11-19"
# }

# case_id = create_ed_case(case_info)

# print("Case created successfully! Case ID:", case_id)
from services.records import search_ed_case

record = search_ed_case(1)

if record:
    print("Case found!")
    print(record)
else:
    print("Case not found!")