n = int(input("Enter a number: "))

if n % 2 == 0:
    n += 1

for i in range(1, n+2, 2):
    for j in range(0, n//2 - (i//2)):
        print(" ", end="")
    for j in range(0, i):
        print("*", end="")
    print()
for i in range(n-2, 0, -2):
    for j in range(0, n//2 - (i//2)):
        print(" ", end="")
    for j in range(0, i):
        print("*", end="")
    print()