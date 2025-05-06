n = int(input("Enter an integer N: "))

ctr = 0
while n != 0:
    ctr += 1
    if n % 2 == 1:
        n -= 1
    else:
        n //= 2

print("Number of steps to reduce to 0:", ctr)