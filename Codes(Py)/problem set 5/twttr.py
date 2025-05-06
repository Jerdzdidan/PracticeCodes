VOWELS = ["a", "e", "i", "o", "u"]

def twttr(input):
    result = ""
    for letter in input:
        if letter not in VOWELS:
            result += letter
    return result

def main():
    input = input("Input: ")
    twttr(input)

if __name__ == "__main__":
    main()