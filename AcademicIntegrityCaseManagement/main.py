from services.records import initialize_database,create_case,search_case

def display_menu(): 
    print("\n====AICMS====")
    print("1. Create New Case")
    print("2. Search Case")
    print("3. Display All Cases")
    print("4. Update Case")
    print("5. Delete Case")
    print("6. Exit")

def collect_case_information(): 
    fields=[
        "student_name",
        "student_number",
        "student_email",
        "faculty_name",
        "course",
        "report_date"
    ]
    case_info= {}
    for field in fields:
        value = input(f"Enter {field.replace('_',' ').title()}: ")
        case_info[field] = value
    return case_info
def main():
    initialize_database()
    while True: 
        display_menu()
        choice = input("Enter your choice(1-6): ")

        match choice: 
            case "1": 
                case_info = collect_case_information()
                print("\nCollected Case Information")
                # print("New Case creation")
                for key, value in case_info.items():
                    print(f"{key}:{value}")
                create_case(case_info)
            case "2":
                field_name = "Student ID"
                student_id = input("Enter Student ID: ")
                # search_case(student_id)
                # print(search_case)
                records = search_case(student_id)
                if records: 
                    for record in records:
                        print(record)
                else:
                    print("No such student")
            case "3": 
                print("All Cases")
            case "4":
                print("Choose case to update")
            case "5":
                print("Choose case to delete")
            case "6":
                print("Goodbye")
                break
            case _:
                print("invalid choice, Try again")
    print("AICMS Database Initialized successfully")



if __name__ == "__main__":
    main()