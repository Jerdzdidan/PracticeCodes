n = int(input("Enter the value of N: "))

array = []
print(f"Enter {n} integers: ")
for i in range(n):
    array.append(int(input("")))

ctr_pos = 0
ctr_neg = 0

for i in range(n):
    if array[i] < 0:
        ctr_neg += 1
    elif array[i] > 0:
        ctr_pos += 1

if ctr_pos > ctr_neg:
    print("Maximum count:", ctr_pos)
elif ctr_pos < ctr_neg:
    print("Maximum count:", ctr_neg)
else:
    print("Maximum count:", ctr_pos)