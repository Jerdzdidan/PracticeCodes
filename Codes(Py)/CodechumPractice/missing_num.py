n = int(input("Enter the number of elements: "))

print(f"Enter 7 elements (between 1 and {n+1}):")
array = input("").split()

array.sort()
missing_num = 0

for i in range(n):
    if i not in array:
        missing_num = i

print("Missing number is:", missing_num)