students = []

with open("students.csv", "r") as file:
    for line in file:
        student = {}
        student["name"], student["house"] = line.rstrip().split(",")
        students.append(student)

def get_student(student):
    return student["name"]    

for student in sorted(students, key=get_student):
    print(f"{student['name']} is in {student['house']}")