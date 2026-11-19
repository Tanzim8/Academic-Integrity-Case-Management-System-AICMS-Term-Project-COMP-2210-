
from services.records import register_user

sample_users = [
    # Students
    ("T10000001", "Alex Morgan", "alex@example.com",
     "Computing Science", "Student", "alex01", "TestPass123!"),

    ("T10000002", "Sarah Wilson", "sarah@example.com",
     "Mathematics", "Student", "sarah01", "TestPass123!"),

    ("T10000003", "David Chen", "david@example.com",
     "Engineering", "Student", "david01", "TestPass123!"),

    ("T10000004", "Emily Carter", "emily@example.com",
     "Computing Science", "Student", "emily01", "TestPass123!"),

    ("T10000005", "James Patel", "james@example.com",
     "Business", "Student", "james01", "TestPass123!"),

    # Faculty
    ("F1001", "Dr. Robert Smith", "robert@example.com",
     "Computing Science", "Faculty", "smith01", "TestPass123!"),

    ("F1002", "Dr. Jennifer Lee", "jennifer@example.com",
     "Mathematics", "Faculty", "lee01", "TestPass123!"),

    ("F1003", "Dr. Michael Brown", "michael@example.com",
     "Engineering", "Faculty", "brown01", "TestPass123!")
]

for user in sample_users:
    register_user(*user)
    print("Registered:", user[1], "| ID:", user[0])

print("Sample users created successfully!")
