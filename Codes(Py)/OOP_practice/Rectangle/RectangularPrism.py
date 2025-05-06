from Shape import Shape

class RectangularPrism(Shape):
    def __init__(self, length, width, height):
        super().__init__(length, width)
        self._height = height
    
    def setHeight(self, value):
        self._height = value
    
    def computeArea(self):
        self._area = 2 * ((self.getData1() + self.getData2()) + (self._height * self.getData1()) + (self._height * self.getData2()))
    def computeVolume(self):
        self._volume = self.getData1() * self.getData2() * self._height

    def getHeight(self):
        return self._height
    def getVolume(self):
        return self._volume
    def getArea(self):
        return self._area