vowels = ["A", "E", "I", "O", "U", "a", "e", "i", "o", "u"]

twttr = input("Input: ")

print("Output: ", end="")

for letter in twttr:
    if letter in vowels:
        print("", end="")
    else:
        print(letter, end ="")