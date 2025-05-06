def is_anagram(x, y):
    if sorted(x) == sorted(y):
        return True
    else:
        return False

string1 = input("Enter string 1: ")
string2 = input("Enter string 2: ")

boolean = is_anagram(string1, string2)

if boolean:
    print("The strings are anagrams of each other.")
else:
    print("The strings are not anagrams of each other.")