number = int(input("Enter a number: "))

print("Result:")
while True:
    print(int(number), end=" ")

    if number == 1:
        break

    if number % 2 == 0:
        number/=2
    else:
        number = (3 * number) + 1