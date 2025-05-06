from math import ceil
name = input("Enter name: ")

while True:
    box_size = int(input("Enter box size: "))

    if box_size - 2 < len(name):
        print("Choose a larger box")
    else:
        break


length = ceil(box_size / 2)
width = box_size

for i in range(length):
    for j in range(width):
        if i == 0 or i == (length) - 1:
            print("*", end="")
        else:
            if j == 0 or j == width - 1:
                print("*", end="")
            elif i == length // 2 and (width - len(name)) // 2 <= j < (width + len(name)) // 2:
                print(name[j - (width - len(name)) // 2], end="")
            else:
                print(" ", end="")
    print()