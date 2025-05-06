n = int(input("Enter Num: "))

zero = 0

while n > 0:
    if n % 10 == 0:
        zero+=1
    
    n/=10

print(zero)