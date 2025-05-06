size = int(input("Enter the size of the array: "))

array = []

for i in range(size):
    array.append(int(input(f"Enter the element {i+1} for the array: ")))

max_num = max(array)
sec_max_num = -99999999
sec_max_num_index = -1

for i in range(size):
    if array[i] > sec_max_num and array[i] != max_num:
        sec_max_num = array[i]
        sec_max_num_index = i


print("Result:", sec_max_num_index)