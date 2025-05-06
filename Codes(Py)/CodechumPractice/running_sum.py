n = int(input("Enter the number of integers: "))
numbers = []

print(f"Enter {n} integers:")
for i in range(n):
    numbers.append(int(input("")))

print("Running sums are:")
sum = 0
for i in range(0, n, 1): 
    sum += numbers[i]
    print(sum, end=" ")