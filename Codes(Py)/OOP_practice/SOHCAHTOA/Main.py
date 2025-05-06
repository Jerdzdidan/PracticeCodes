from Triangle import Triangle

t = Triangle()

t.setData1(int(input("Input Adjacent Side: ")))
t.setData2(int(input("Input Opposite Side: ")))
t.setData3(int(input("Input Hypotenuse Side: ")))
t.setHeight(int(input("Input Height: ")))

t.computeArea()
t.computePerimeter()
t.evaluateTypeOfTriangle()

print("\nArea:", t.getArea())
print("Perimeter:", t.getPerimeter())
print("Type of Triangle:", t.getTypeOfTriangle())