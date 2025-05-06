from PIL import Image, ImageDraw, ImageFont
import qrcode
import sys

font = ImageFont.truetype('arial', 17) 

while True:
    print("\n\nType STOP to stop the program and UNDO to go back.\n")
   
    name = input("Input Name: ")
    if name.upper() == "STOP":
        break
    elif name.upper() == "UNDO":
        continue

    student_num = input("Input Student Number: ")
    if student_num.upper() == "STOP":
        break
    elif student_num.upper() == "UNDO":
        continue

    course_year_and_section = input("Input Course - Year and Section: ")
    if course_year_and_section.upper() == "STOP":
        break
    elif course_year_and_section.upper() == "UNDO":
        continue

    data = f"{name}, {student_num}, {course_year_and_section}"

    qr = qrcode.QRCode(version=1, box_size=10, border=5)
    qr.add_data(data)
    qr.make(fit=True)
    img = qr.make_image(fill_color='black', back_color='white')

    draw = ImageDraw.Draw(img)
    draw.text((5,2,  img.size[1]-10), name, font=font, fill='black') 
    draw.text((5,19,  img.size[1]-10), student_num, font=font, fill='black')
    draw.text((333,2,  img.size[1]-10), course_year_and_section, font=font, fill='black')

    img.save(f'{name}.png')