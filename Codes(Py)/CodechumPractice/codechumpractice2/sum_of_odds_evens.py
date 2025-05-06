first_num = int(input("Enter first number: "))
second_num = int(input("Enter second number: "))

sum_odd = 0
sum_even = 0
for i in range(first_num, second_num+1):
    if i % 2 == 0:
        sum_even+=i
    else:
        sum_odd+=i

print("Sum of odds:", sum_odd)
print("Sum of even:", sum_even)