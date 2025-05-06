import statistics


list = [40, 61, 95, 79, 9, 50, 80, 63, 109, 42]

max = 0
min = list[0]
for n in list:
    if min > n:
        min = n
    if max < n:
        max = n

print("Range", max - min)
print("Mean", statistics.mean(list))
print("Mode", statistics.mode(list))
print("Median", statistics.median(list))
print("Sorted list", sorted(list))