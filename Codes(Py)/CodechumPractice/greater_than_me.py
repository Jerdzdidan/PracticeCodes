n = int(input("Enter the number of integers: "))
numbers = []

print(f"Enter {n} integers:")
for i in range(n):
    numbers.append(int(input("")))

counts = []
for i in range(n):
    ctr= 0
    for j in range(n): 
        if j != i and numbers[j] > numbers[i]:
            ctr+=1
    counts.append(ctr)

print("Result:", counts)