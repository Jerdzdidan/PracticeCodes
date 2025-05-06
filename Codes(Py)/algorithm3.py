list = []

# INPUT
n = int(input("\nEnter the number of elements in the list: "))
for i in range(n):
    element = int(input(f"Enter element {i+1}: "))
    list.append(element)

print("\nThe list is:", list)

# PROCESS
for i in range(len(list)):
    for j in range(i+1, len(list)):
        if list[i] > list[j]:
            temp = list[i]
            list[i] = list[j]
            list[j] = temp

# OUTPUT
print(f"The sorted list is: {list}\n")