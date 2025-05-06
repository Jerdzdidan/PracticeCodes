size1 = int(input("Enter the size of the first array: "))
print(f"Enter {size1} elements of the first array(sorted):")
array1 = input("").split()
array1 = [int(n) for n in array1]

size2 = int(input("Enter the size of the second array: "))
print(f"Enter {size2} elements of the second array(sorted):")
array2 = input("").split()
array2 = [int(n) for n in array2]

common_elements = []
for i in range(size1):
    for j in range(size2):
        if array1[i] not in common_elements:
            if array1[i] == array2[j]:
                common_elements.append(array1[i])

print("Unique common elements are: ", end="")
for i in range(len(common_elements)):
    print(common_elements[i], end=" ")