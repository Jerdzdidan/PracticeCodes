sample = [
    59, 50, 52, 38, 80, 62, 77, 56, 
    60, 61, 58, 62, 51, 36, 54, 18, 
    71, 54, 44, 52, 26, 63, 58, 56, 
    41, 34, 61, 50, 60, 53, 62, 62, 
    53, 43, 63, 71, 65, 79, 45, 66
]
sample.sort()

ll = sample[0]
farray = []
f_sum = 0
rfsum = 0
lcf = 0
gcf = []

print("\n\n\n\n\n\n\nSorted List:")
for i in range(0, len(sample), 8):
    print("    ", end="")
    print(*sample[i:i+8], sep=", ")
print("\nRange = ", sample[-1] - sample[0])

print("\n    Classes   | Frequency  | Classmark |    R.f%    | <cf  | >cf")
for i in range(7):
    frequency = 0
    up = ll + 8
    for n in range(len(sample)):
        if sample[n] >= ll and sample[n] <= up:
            frequency += 1
    
    farray.append(frequency)
    f_sum += frequency
    ll+=9

j = f_sum
for i in range(7):
    gcf.append(j) 
    j -= farray[i]

up = 0
ll = sample[0]

for i in range(7):
    up = ll + 8
    classmark = (up + ll) // 2

    lcf += farray[i]
    
    print(f"    {ll} - {up}   |     {f'{farray[i]}'.zfill(2)}     |    {classmark}     |   {f'{(farray[i] / f_sum) * 100:.2f}'.zfill(5)}%   |  {f'{lcf}'.zfill(2)}  |  {gcf[i]}")
    rfsum += (farray[i] / f_sum) * 100
    ll+=9

print(f"---------------------------------------------------------------")
print(f"Class size = 9|   n = {f_sum}   |           |  {rfsum:.2f}%   |")


print("\n1.	What is the range? : ", sample[-1] - sample[0])
print("2.	The total frequency? : ", f_sum)
print("3.	The relative frequency of the class with the highest frequency? : 37.50%")
print("4.	The relative frequency of the class with the lowest frequency? : 2.50%")
print("5.	The midpoint of the 5th class? : 58")
print("6.	The midpoint of the 2nd class? : 31")
print("7.	The less than cumulative frequency of the 7th class? : 40")
print("8.	The greater then cumulative frequency of the 3rd class? : 37")
print("9.	What is the upper limit of the 5th class? : 62")
print("10.	What is the boundary of the upper limit of 2nd class? : 35.5")
print("11.	What is the class boundary of the lower limit of 2nd class? : 26.5")
print("12.	What class has the highest frequency? : 5\n\n\n\n\n\n\n\n\n\n\n\n\n")