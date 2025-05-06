string = input("Enter string: ").lower()
reversed_string = string[::-1]

if string == reversed_string:
    print(f"The string '{string}' is a palindrome.")
else:
    print(f"The string '{string}' is not a palindrome.")