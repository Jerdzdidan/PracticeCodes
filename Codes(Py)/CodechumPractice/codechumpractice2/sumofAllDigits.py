numbers = input("Enter a number: ").replace("-", "")

sum = 0
for n in numbers:
    temp = int(n)
    if temp % 2 == 0:
        sum += temp
    else:
        sum -= temp

print("Result:", sum)