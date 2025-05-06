s = input("Enter a string: ")

ch = {}
freq = ""

for c in s:
    if c in ch:
        ch[c] += 1
        if ch[c] == 2:
            freq = c
            break
    else:
        ch[c] = 1

print("The first letter to appear twice is: ", freq)