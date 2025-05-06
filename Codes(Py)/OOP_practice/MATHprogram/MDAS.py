from Input import Input

class MDAS(Input):
    def __init__(self):
        pass

    def Multiply(self):
        self._product = self.getData1() * self.getData2()
    def Divide(self):
        self._quotient = self.getData1() / self.getData2()
    def Subtract(self):
        self._difference = self.getData1() - self.getData2()
    def Add(self):
        self._sum = self.getData1() + self.getData2()

    def getProduct(self):
        return self._product
    def getQuotient(self):
        return self._quotient
    def getDifference(self):
        return self._difference
    def getSum(self):
        return self._sum