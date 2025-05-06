n = int(input("Enter number: "))

if n % 2 == 0:
    n = n-1
for i in range(0, n):
    for j in range(0, n*2):
        if i > n / 2:
            print("*", end="")
        else:
            print(" ", end="")
    for j in range(0, i):
        print("*", end="")
    print()
    
for i in range(n, 0, -1):
    for j in range(0, n*2):
        if i > n / 2:
            print("*", end="")
        else:
            print(" ", end="")
    for j in range(0, i):
        print("*", end="")
    print()