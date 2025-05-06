n = int(input("Enter the number of integers: "))
numbers = []

print(f"Enter {n} integers:")
for i in range(n):
    numbers.append(int(input("")))

maxdiff = 0
for i in range(n-1):
    if maxdiff <= abs(numbers[i] - numbers[i+1]):
        maxdiff = abs(numbers[i] - numbers[i+1])

print("Maximum difference between two successive elements:", maxdiff)