n = input("Input Number: ")
zero = 0

for i in n:
    if i == '0':
        zero+=1
    else:
        zero = 0

print(zero)