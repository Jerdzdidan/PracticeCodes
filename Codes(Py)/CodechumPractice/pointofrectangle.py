x1 = int(input("Enter x of rectangle point 1: "))
y1 = int(input("Enter y of rectangle point 1: "))
x2 = int(input("Enter x of rectangle point 2: "))
y2 = int(input("Enter y of rectangle point 2: "))

height = abs(y1 - y2)
length = abs(x1 - x2)

perimeter = 2 * (height + length)
area = height * length

print("Perimeter of the rectangle: ", perimeter)
print("Area of the rectangle: ", area)