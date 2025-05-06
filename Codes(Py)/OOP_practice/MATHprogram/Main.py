from MDAS import MDAS
from Average import Average

choice = 0
while (choice < 1 or choice > 2):
    try:
        print("[1]MDAS of 2 numbers")
        print("[2]Average of 3 numbers")
        choice = int(input("Input choice: "))
    except ValueError:
        continue

if (choice == 1):
    m = MDAS()

    m.setData1(int(input("Enter first number: ")))
    m.setData2(int(input("Enter second number: ")))

    m.Multiply()
    m.Divide()
    m.Subtract()
    m.Add()

    print("Sum:", m.getSum())
    print("Difference:", m.getDifference())
    print("Product:", m.getProduct())
    print("Quotient:", m.getQuotient())
else:
    a = Average()

    a.setData1(int(input("Enter first number: ")))
    a.setData2(int(input("Enter second number: ")))
    a.setNum3(int(input("Enter third number: ")))

    a.computeAverage()

    print("Average:", a.getAverage())