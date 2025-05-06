operation = input("Enter operation: ")

fnum, operator, lnum = operation.split(" ")

sig1 = 0
# sig2 = 0

for num in fnum:
    if num != ".":
        if int(num) > 0:
            sig1 += 1
zero = 0
for i in range(len(fnum) - 1):
    if fnum[i] != ".":
        if int(fnum[i]) == 0:
            zero += 1
        if fnum[i+1] != ".":
            zero = 0 
if "." in fnum:
    sig1 += zero
 
# fnum = float(fnum)
# lnum = float(fnum)



print(sig1)