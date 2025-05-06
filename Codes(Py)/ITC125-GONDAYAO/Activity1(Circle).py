from math import pi

radius = float(input("Input radius: "))

area = pi * (radius ** 2)
circumference = 2 * pi * radius
diameter = 2 * radius

print(f"\nArea: {area:.3f}")
print(f"Circumference: {circumference:.3f}")
print(f"Diameter: {diameter:.3f}")