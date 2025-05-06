number = int(input("Enter a number: "))

binary = []

while number > 0:
    digit = number % 2
    number //= 2

    binary.append(digit)

print("Result:", len(binary))