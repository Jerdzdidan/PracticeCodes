def main():
    camelcase()

def camelcase():
    camelcase = input("camelcase: ")
    print("snakecase: ", end="")

    for letter in camelcase:
        if letter == camelcase[0]:
            print(letter.lower(), end = "")
        elif letter.isupper():
            print("_" + letter.lower(), end="")
        else:
            print(letter, end="")

main()