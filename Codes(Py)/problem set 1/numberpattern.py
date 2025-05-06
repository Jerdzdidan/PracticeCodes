def main():
    number = int(input("Enter a number 1-9: "))

    for i in range(i, number, 1):
        for n in range(number - i):
            print(" ", end="")
        for n in range(i):
            print(f"{i} ", end="")
        print()
    for i in range(number, 0, -1):
        for n in range(number - i):
            print(" ", end="")
        for n in range(i):
            print(f"{i} ", end="")
        print()


main()