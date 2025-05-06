def main():
    print("\n\n")
    print_blocks(2, 2)
    print_floor(5, 10)


def print_blocks(height, width):
    for i in range(height):
        for j in range(width):
            print("#", end="")
        print()

def print_floor(height, width):
    for i in range(height):
        for j in range(width):
            print("#", end="")
        print()

def print_wall2(size):
    for i in  range(size):
        for j in range(size):
            print("#", end="")
        print()

main()