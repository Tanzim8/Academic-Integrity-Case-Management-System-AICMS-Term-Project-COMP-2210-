import tkinter as tk

def start_app():
    root = tk.Tk();
    root.title("Academic Integrity Case Management");
    root.geometry("900x650")

    #Form

    form = tk.Frame(root)
    form.pack(pady=30)

    fields = [
        "Student Name",
        "Student Number",
        "Student Email",
        "Faculty Memeber Name",
        "Date(yyyy-mm-dd)",
        "Course Name and Number",
        "Assignment Number or Exam",
        "Department",
        "Term or Semester"
    ]

    entries={}

    for row, field in enumerate(fields):
        tk.Label(form, text=field+":").grid(
            row=row, column=0, padx=10, pady=10, sticky="w"
        )
        entry = tk.Entry(form, width=40)
        entry.grid(row=row, column=1, padx=10, pady=10)
        entries[field] = entry

    # heading = tk.Label(
    #     root,
    #     text="Academic Integrity Case Report",
    #     font=("Arial",20,"bold")
    # )
    # heading.pack(pady=20)

    # #Student name
    # tk.Label(root, text = "Student Name: ").pack()
    # student_name = tk.Entry(root,width=40)
    # student_name.pack(pady=5)

    # #std number
    # tk.Label(root, text = "Student Number: ").pack()
    # student_number = tk.Entry(root,width=40)
    # student_number.pack(pady=5)

    # #Std email
    # tk.Label(root, text = "Student Email: ").pack()
    # student_email = tk.Entry(root,width=40)
    # student_email.pack(pady=5)

    # #Faculty member
    # tk.Label(root, text = "Faculty Member Name: ").pack()
    # faculty_member = tk.Entry(root,width=40)
    # faculty_member.pack(pady=5)

    # #Date
    # tk.Label(root, text = "Date (yyyy-mm-dd): ").pack()
    # date = tk.Entry(root,width=40)
    # date.pack(pady=5)

    # #Course Name and Number
    # tk.Label(root, text = "Course Name and Number: ").pack()
    # course_info = tk.Entry(root,width=40)
    # course_info.pack(pady=5)

    root.mainloop();