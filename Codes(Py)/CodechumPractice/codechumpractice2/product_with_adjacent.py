size = int(input("Enter the size of the array: "))

array = []

for i in range(size):
    array.append(int(input(f"Enter the element {i+1} for the array: ")))

product_array = []

for i in range(size):
    if i == 0:
        product_array.append(array[i] * array[i+1])
    elif i == size - 1:
        product_array.append(array[i - 1] * array[size - 1])
    else:
        product_array.append(array[i-1] * array[i] * array[i+1])

print("Result:", product_array)