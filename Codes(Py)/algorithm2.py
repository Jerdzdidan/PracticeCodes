a = 0
b = 1
list = []

# INPUT
n = input("\nEnter the nth term of the Fibonacci sequence: ")

# CONSTRAINTS
if n.isdigit() == False:
    exit()
else:
    n = int(n)

# PROCESS
for i in range(n):
    list.append(a)
    c = a + b
    a = b
    b = c

# OUTPUT
print(f"\nThe Fibonacci sequence up to the {n}th term is: {list}\n")