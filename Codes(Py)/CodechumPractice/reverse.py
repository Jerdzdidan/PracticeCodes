n = int(input("Enter a number: "))

num = n
reversedN = 0
reversereversedN = 0

while n != 0:
    digit = n % 10
    reversedN = reversedN * 10 + digit
    n //= 10

while reversedN != 0:
    digit = reversedN % 10
    reversereversedN = reversereversedN * 10 + digit
    reversedN //= 10

if reversereversedN == num:
    print("True")
else:
    print("False")