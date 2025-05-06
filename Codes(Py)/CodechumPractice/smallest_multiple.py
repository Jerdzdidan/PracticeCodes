n = int(input("Enter a positive integer: "))

m = 0
if n % 2 == 1:
    m = n * 2
else:
    m = n

print("Result:", m)