from services.records import initialize_database,create_case,search_case, display_all_cases,delete_case,update_case

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
        "faculty_comments",
        "student_comments"
    ]
    case_info= {}
    for field in fields:
        if field in ["support_person_advised","written_statement_advised","evidence_reviewed","chair_agrees", "dean_agrees"]:
            while True: 
                answer = input(
                    f"Enter {field.replace('_',' ').title()} (Y/N)"
                ).strip().lower()

                if answer in ["y","n"]:
                    value = 1 if answer =="y" else 0
                    break
                else: 
                    print("Invalid input! Please enter Y or N")
        else:
            value = input(f"Enter {field.replace('_',' ').title()}: ")
        case_info[field] = value
    return case_info

def get_update_fields():
    connection_fields = [
        "student_name", "student_number", "student_email",
        "faculty_name", "course", "report_date",
        "assignment_number", "department", "semester",
        "violation_description", "support_person_advised",
        "written_statement_advised", "faculty_signature",
        "faculty_signature_date", "student_acknowledgement_name",
        "evidence_reviewed", "mytru_email", "student_signature",
        "student_signature_date", "faculty_followup_signature",
        "faculty_followup_name", "faculty_followup_date",
        "chair_agrees", "chair_comments", "chair_signature",
        "chair_name", "chair_date", "dean_agrees",
        "dean_comments", "dean_signature", "dean_name",
        "dean_date", "faculty_comments", "student_comments"
    ]
    return connection_fields
    
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
                search_fields = {
                    "1": "record_id",
                    "2": "student_name",
                    "3": "student_number",
                    "4": "faculty_name"
                }
                print("\nSearch Case By:")
                for number, field in search_fields.items():
                    print(f"{number}. {field.replace('_', ' ').title()}")

                search_choice = input("Enter choice (1-4): ")

                if search_choice in search_fields:
                    field = search_fields[search_choice]
                    value = input(f"Enter {field.replace('_', ' ').title()}: ")

                    records = search_case(field, value)

                    if records:
                        for record in records:
                            print(record)
                    else:
                        print("No matching records found.")
                else:
                    print("Invalid search option.")
            case "3": 
                # print("All Cases")
                records = display_all_cases()

                if records: 
                    for record in records:
                        print(record)
                else: 
                    print("Empty Database")
            case "4":
                user_input = int(input("Emter the record ID: "))

                records = search_case("record_id",user_input)

                if records: 
                    print("\nCurrent Record:")
                    print(records[0])

                    fields = {
                        "1": "student_name",
                        "2": "student_number",
                        "3":"student_email",
                        "4":"faculty_name",
                        "5":"course",
                        "6":"report_date",
                        "7": "assignment_number",
                        "8": "department",
                        "9": "semester",
                        "10": "violation_description",
                        "11": "support_person_advised",
                        "12": "written_statement_advised",
                        "13": "faculty_signature",
                        "14": "faculty_signature_date",
                        "15": "student_acknowledgement_name",
                        "16": "evidence_reviewed",
                        "17": "mytru_email",
                        "18": "student_signature",
                        "19": "student_signature_date",
                        "20": "faculty_followup_signature",
                        "21": "faculty_followup_name",
                        "22": "faculty_followup_date",
                        "23": "chair_agrees",
                        "24": "chair_comments",
                        "25": "chair_signature",
                        "26": "chair_name",
                        "27": "chair_date",
                        "28": "dean_agrees",
                        "29": "dean_comments",
                        "30": "dean_signature",
                        "31": "dean_name",
                        "32": "dean_date",
                        "33": "faculty_comments",
                        "34": "student_comments"
                    }

                    print("\nWhich fields you want to update?")
                    for number, field in fields.items():
                        print(f"{number}. {field}")

                    field_choice = input("Enter your choice (1-6): ")

                    if field_choice in fields: 
                        field = fields[field_choice]
                        new_value = input(f"Enter new{field}: ")

                        update_case(user_input,field,new_value)

                        print("Records updated") 
                    else: 
                        print("Invalid field choice.")     
                else:
                    print("Record not found.")

                # print("Choose case to update")
            case "5":
                user_input = int(input("Enter record ID: "))

                records = search_case("record_id", user_input)

                if records:
                    print("To Delete: ")
                    for record in records: 
                        print(record)
                    user_confirmation = int(input("Press 1 to confirm deletion: "))
                    if user_confirmation != 1:
                        user_confirmation = int(input("Press 1 to confirm deletion: "))
                    else: 
                        delete_case(user_input)
                print("Choose case to delete")
            case "6":
                print("Goodbye")
                break
            case _:
                print("invalid choice, Try again")
    print("Thanks for using AICMS!")



if __name__ == "__main__":
    main()