from Shape import Shape

class Triangle(Shape):
    def __init__(self):
        pass

    def setHeight(self, value):
        self._height = value
    
    def computeArea(self):
        self._area = (self.getData2() + self._height) / 2
    def computePerimeter(self):
        self._perimeter = self.getData1() + self.getData2() + self.getData3()
    
    def evaluateTypeOfTriangle(self):
        if self.getData1() == self.getData3() and self.getData3() == self.getData2() and self.getData1() == self.getData2():
            self._typeOfTriangle = "Equilateral Triangle"
        elif self.getData1() == self.getData3() or self.getData3() == self.getData2() or self.getData1() == self.getData2():
            self._typeOfTriangle = "Iscoceles Triangle"
        else:
            self._typeOfTriangle = "Scalene Triangle"
    
    def getHeight(self):
        return self._height
    def getArea(self):
        return self._area
    def getPerimeter(self):
        return self._perimeter
    def getTypeOfTriangle(self):
        return self._typeOfTriangle