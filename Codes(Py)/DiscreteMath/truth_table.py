# "NOT" OPERATOR EXAMPLE
i = 10
j = 5
print("\nGondayao, Jerdan L. - BSCS2A")
print("DISCRETE STRUCTURE TRUTH TABLE PROGRAM")
print('\n"NOT" Operator Example:')
print(f"Where i = {i} and j = {j}.")
print(" ________________ __________")
print("|       p        |    !p    |")
print(" ---------------- ---------- ")

# P = i > j with the expression: !(i > j).
print(f"|  i > j = {i > j}  |   {not(i > j)}  |")
print(" ---------------- ---------- ")

# P = i < j with the expression: !(i < j).
print(f"|  i < j = {i < j} |   {not(i < j)}   |")
print(" ---------------- ---------- ")



# "AND" OPERATOR EXAMPLE
x = 15
y = 6
print('\n\n"AND" Operator Example:')
print("Where i = 10, j = 5 and x = 15, y = 6")
print(" _________________ _________________ __________")
print("|        p        |        q        |  p && q  |")
print(" ----------------- ----------------- ----------")

# P = i > j and Q = x > y with the expression: (i > j) && (x > y)
print(f"|  i > j = {i > j}   |  x > y = {x > y}   |   {(i > j) and (x > y)}   |")
print(" ----------------- ----------------- ----------")

# P = x > y and Q = x < y with the expression: (x > y) && (x < y)
print(f"|  x > y = {x > y}   |  x < y = {x < y}  |   {(x > y) and (x < y)}  |")
print(" ----------------- ----------------- ----------")

# P = i < j and Q = i > j with the expression: (i < j) && (i > j)
print(f"|  i < j = {i < j}  |  i > j = {i > j}   |   {(i < j) and (i > j)}  |")
print(" ----------------- ----------------- ----------")

# P = x < y and Q = i < j with the expression: (x < y) && (i < j)
print(f"|  x < y = {x < y}  |  i < j = {i < j}  |   {(x < y) and (i < j)}  |")
print(" ----------------- ----------------- ----------")



# "OR" OPERATOR EXAMPLE
print('\n\n"OR" Operator Example with the same given:')
print("i = 10, j = 5 and x = 15, y = 6")
print(" _________________ _________________ __________")
print("|        p        |        q        |  p || q  |")
print(" ----------------- ----------------- ----------")

# P = i > j and Q = x > y with the expression: (i > j) || (x > y)
print(f"|  i > j = {i > j}   |  x > y = {x > y}   |   {(i > j) or (x > y)}   |")
print(" ----------------- ----------------- ----------")

# P = x > y and Q = x < y with the expression: (x > y) || (x < y)
print(f"|  x > y = {x > y}   |  x < y = {x < y}  |   {(x > y) or (x < y)}   |")
print(" ----------------- ----------------- ----------")

# P = i < j and Q = i > j with the expression: (i < j) || (i > j)
print(f"|  i < j = {i < j}  |  i > j = {i > j}   |   {(i < j) or (i > j)}   |")
print(" ----------------- ----------------- ----------")

# P = x < y and Q = i < j with the expression: (x < y) || (i < j)
print(f"|  x < y = {x < y}  |  i < j = {i < j}  |   {(x < y) or (i < j)}  |")
print(" ----------------- ----------------- ----------")



# "XOR" OPERATOR EXAMPLE
print('\n\n"XOR" Operator Example with the same given:')
print("i = 10, j = 5 and x = 15, y = 6")
print(" _________________ _________________ ___________")
print("|        p        |        q        |  p XOR q  |")
print(" ----------------- ----------------- -----------")

# P = i > j and Q = x > y with the expression: (i > j) ^ (x > y)
print(f"|  i > j = {i > j}   |  x > y = {x > y}   |   {(i > j) ^ (x > y)}   |")
print(" ----------------- ----------------- -----------")

# P = x > y and Q = x < y with the expression: (x > y) ^ (x < y)
print(f"|  x > y = {x > y}   |  x < y = {x < y}  |   {(x > y) ^ (x < y)}    |")
print(" ----------------- ----------------- -----------")

# P = i < j and Q = i > j with the expression: (i < j) ^ (i > j)
print(f"|  i < j = {i < j}  |  i > j = {i > j}   |   {(i < j) ^ (i > j)}    |")
print(" ----------------- ----------------- -----------")

# P = x < y and Q = i < j with the expression: (x < y) ^ (i < j)
print(f"|  x < y = {x < y}  |  i < j = {i < j}  |   {(x < y) ^ (i < j)}   |")
print(" ----------------- ----------------- -----------")