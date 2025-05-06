n = int(input("Enter a positive integer n: "))

sum = 0
for i in range(n + 1):
    if i % 3 == 0 or i % 5 == 0 or i % 7 == 0:
        sum += i
    
print("Sum of all integers:", sum)