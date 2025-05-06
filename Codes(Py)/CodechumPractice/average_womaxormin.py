n = int(input("Enter the value of N: "))

nums = []
print(f"Enter {n} integers: ")
for i in range(n):
    nums.append(int(input("")))

nums.sort()

sum = 0
for i in range(1, n-1, 1):
    sum += nums[i]

print(f"Average: {sum / (n-2):.2f}")