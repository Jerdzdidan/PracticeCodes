size1 = int(input("Enter the size of the first array: "))
array1 = []
for i in range(size1):
    array1.append(int(input(f"Enter the element {i+1} for the first array: ")))


size2 = int(input("Enter the size of the first array: "))
array2 = []
for i in range(size2):
    array2.append(int(input(f"Enter the element {i+1} for the first array: ")))


intersection = []
for i in range(size1):
    for j in range(size2):
        if array1[i] == array2[j]:
            intersection.append(array1[i])

print("Intersection of the two arrays:", intersection)