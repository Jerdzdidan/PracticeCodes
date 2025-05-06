import time

a = 1
b = 0
c = a + b

while True:
    print(f"{c}, ", end = "")
    c = a + b
    b = a
    a = c
    time.sleep(.20)
