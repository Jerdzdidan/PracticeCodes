number = int(input("Enter an integer: "))

binary = bin(number)[2:]

boolean = "true"

for i in range(len(binary)-1):
    if binary[i] == binary[i + 1]:
        boolean = "false"

print(boolean)