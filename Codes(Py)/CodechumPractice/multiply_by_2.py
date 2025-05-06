n = int(input("Enter the value of N: "))

array = []
print(f"Enter {n} integers: ")
for i in range(n):
    array.append(int(input("")))

original = int(input("Enter the value of original: "))

while True:
    if original in array:
        original *= 2
        continue
    else:
        break

print("Final value of original:", original)