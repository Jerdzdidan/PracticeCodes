number = input("Enter a positive integer: ")

sum = 0
temp = 0

i = 0
for n in number:
    if (i + 1) % 2 == 1:
        temp = int(n)
    else:
        temp = int(n)
        temp = (temp - temp) - int(n)
    i+=1
    sum += temp

print("Sum: ", sum)