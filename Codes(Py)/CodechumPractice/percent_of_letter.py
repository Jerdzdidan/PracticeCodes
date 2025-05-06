string = input("Enter a string: ")
ch = input("Enter a character: ")

sum = len(string)
numc = 0

for letter in string:
    if letter == ch:
        numc += 1

percentage = (numc / sum) * 100

print(f"Percentage: {int(percentage)}%")