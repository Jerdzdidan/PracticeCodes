n = int(input("Enter the value of N: "))

nums = []
print(f"Enter {n} integers: ")
for i in range(n):
    nums.append(int(input("")))

ctr = 0
for i in range(n):
    if (nums[i] - 1) % 3 == 0 or (nums[i] + 1) % 3 == 0:
        ctr += 1

print("Minimum number of operations:", ctr)