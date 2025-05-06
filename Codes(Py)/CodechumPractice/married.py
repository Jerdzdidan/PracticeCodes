groom_inp = input("Enter groom's name: ")
bride_inp = input("Enter bride's name: ")

groom = groom_inp.split()
bride = bride_inp.split()
new_mid_name = bride[2]

print(f"Congratulations, Mr. {groom_inp} and Mrs. {bride[0]} {new_mid_name[0]}. {groom[2]}!")