from Input import Input

class Average(Input):
    def __init__(self):
        pass

    def setNum3(self, value):
        self._num3 = value

    def computeAverage(self):
        self._average = (self.getData1() + self.getData2() + self._num3) / 3
    
    def getNum3(self):
        return self._num3
    def getAverage(self):
        return self._average