n = int(input("Enter the value of N: "))

array = []
print(f"Enter {n} integers: ")
for i in range(n):
    array.append(int(input("")))

k = int(input("Enter the integer K: "))
ctr = 0
for i in range(n):
    for j in range(i+1, n):
        if array[i] == array[j] and (i*j) % k == 0:
            ctr += 1

print("Number of valid pairs:", ctr)