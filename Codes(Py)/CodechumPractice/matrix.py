valid = True

matrix1 = []
matrix2 = []
res = []

while valid:
    a, b= input("Enter matrix 1's number of rows and columns: ").split(" ")
    c, d= input("Enter matrix 2's number of rows and columns: ").split(" ")

    a = int(a)
    b = int(b)
    c = int(c)
    d = int(d)

    if b == c:
        valid = False
    else:
        valid = True
        print("Invalid dimensions")
        pass

print("Matrix 1: ")
for r in range(a):
    item_input = input(f"Row {r + 1}: ")
    items = item_input.split()
    items = [int(item) for item in items]
    matrix1.append(items)

print("Matrix 2: ")
for r in range(c):
    item_input = input(f"Row {r + 1}: ")
    items = item_input.split()
    items = [int(item) for item in items]
    matrix2.append(items)

res = [[0] * d for _ in range(a)]
for i in range(a):
    for j in range(d):
        sum_product = 0
        for k in range(c):
            sum_product += matrix1[i][k] * matrix2[k][j]
        res[i][j] = sum_product

for i in range(0, a):
    for j in range(d):
        print(res[i][j], end = " ")
    print()