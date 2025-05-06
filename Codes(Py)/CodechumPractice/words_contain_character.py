n = int(input("Enter the number of strings: "))

strings = []
print("Enter 4 strings:")
for i in range(n):
    strings.append(input(""))

character = input("Enter the character to search for: ")

filtered_strings = [string for string in strings if character in string]

print(f"Strings containing the character '{character}':")
for string in filtered_strings:
    print(string)