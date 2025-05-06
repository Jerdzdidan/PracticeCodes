strlength = int(input("Enter the number of integers: "))

array = []
print(f"Enter {strlength} integers:")
for i in range(strlength):
    array.append(int(input("")))

counts = {}
for num in array:
    if num in counts:
        counts[num] += 1
    elif num % 2 == 0 and num != 0:
        counts[num] = 1
    else:
        pass

frequent = []
max_count = 0

for num, count in counts.items():
    if count >= max_count:
        frequent.append(num)
        max_count = count

temp = frequent[0]
for n in frequent:
    if n > temp:
        frequent.remove(n)


print(f"Most Frequent Even Element: {frequent[0]}")