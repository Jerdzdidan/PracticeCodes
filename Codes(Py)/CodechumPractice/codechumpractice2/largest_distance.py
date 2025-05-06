size = int(input("Enter the size of the array: "))

array = []
for i in range(size):
    array.append(int(input(f"Enter the element {i+1} for the array: ")))

max_num = max(array)
min_num = min(array)

distance = max_num - min_num

print("Result:", distance)
