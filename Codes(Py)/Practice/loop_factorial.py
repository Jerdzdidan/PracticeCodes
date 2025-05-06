n = int(input("Enter number: "))

product = 0

for i in range(n-1, 0, -1):
    print(i)
    if i == 0:
        break

    n *= i

print(n)