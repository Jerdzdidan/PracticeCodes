from Rectangle import Rectangle
from RectangularPrism import RectangularPrism

rectangle = Rectangle(20, 10)
prism = RectangularPrism(25, 15, 10)

rectangle.computeArea()
rectangle.computePerimeter()

prism.computeArea()
prism.computeVolume()

print("Rectangle:")
print("Length:", format(rectangle.getData1(), ".2f"))
print("Width:", format(rectangle.getData2(), ".2f"))
print("Area:", format(rectangle.getArea(), ".2f"))
print("Perimeter:", format(rectangle.getPerimeter(), ".2f"))

print("\nRectangular Prism: ")
print("Length:", format(prism.getData1(), ".2f"))
print("Width:", format(prism.getData2(), ".2f"))
print("Height:", format(prism.getHeight(), ".2f"))
print("Area:", format(prism.getArea(), ".2f"))
print("Volume:", format(prism.getVolume(), ".2f"))