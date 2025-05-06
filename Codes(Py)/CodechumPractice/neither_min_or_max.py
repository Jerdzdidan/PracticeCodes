n = int(input("Enter the value of N: "))

array = []
print(f"Enter {n} integers: ")
for i in range(n):
    array.append(int(input("")))

array.sort()
if len(array) <= 2:
    print("Result: -1")
else:
    print("Result:", array[1])