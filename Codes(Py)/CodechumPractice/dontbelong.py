number_of_strings = int(input("Number of strings: "))

strings = []

for i in range(number_of_strings):
    strings.append(input(f"Enter string {i + 1}: ").lower())

excluded_letter = input("Enter excluded character: ").lower()

filtered_string = [s for s in strings if excluded_letter not in s]

if len(filtered_string) == 0:
    print("\nNo one belongs")
else:
    print("\nYou belong with us:")
    filtered_string.reverse()
    for string in filtered_string:
        print(string)