from Shape import Shape

class Rectangle(Shape):
    def __init__(self, length, width):
        super().__init__(length, width)

    def computeArea(self):
        self._area = self.getData1() * self.getData2()
    
    def computePerimeter(self):
        self._perimeter = 2 * (self.getData1() + self.getData2())
    
    def getArea(self):
        return self._area
    def getPerimeter(self):
        return self._perimeter