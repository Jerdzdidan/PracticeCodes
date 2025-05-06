sentence = input("Enter a sentence: ")
vowels = ['a', 'e', 'i', 'o', 'u']

ctr = 0
for letter in sentence.lower():
    if letter in vowels:
        ctr += 1

print("Vowels:", ctr)