string = input("Enter the string: ")

filtered_string = ""
temp = ""
for character in string:
    if character.isalpha():
        filtered_string += character
        temp = character
    elif character.isnumeric:
        filtered_string += chr(ord(temp) + int(character))
    
print("Transformed string:", filtered_string)