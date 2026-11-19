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
from services.records import search_ed_case,update_ed_case,update_ed_comments,delete_ed_case, search_student_cases,search_faculty_cases

record = search_ed_case(1)

if record:
    print("Case found!")
    print(record)
else:
    print("Case not found!")

result = update_ed_case(1, "term", "Winter 2027")

print("Update successful:", result)
print(search_ed_case(1))

resultUpdate = update_ed_comments(
    1,
    "student_comments",
    "I understand the academic integrity policy."
)

print("Comment updated:", resultUpdate)
print(search_ed_case(1))

case_id = 17

print("Before deletion:", search_ed_case(case_id))

result = delete_ed_case(case_id)

print("Deletion successful:", result)
print("After deletion:", search_ed_case(case_id))

student_id = "T00716893"

records = search_student_cases(student_id)

print("Total cases found:", len(records))

for record in records:
    print(record)

recordsFaculty = search_faculty_cases("F1001")

print("Total faculty cases:", len(recordsFaculty))

for record in recordsFaculty:
    print(record)