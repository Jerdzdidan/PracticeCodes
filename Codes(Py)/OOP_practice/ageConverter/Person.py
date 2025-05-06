class Person:
    def __init__(self, name, birthyear):
        self._name = name
        self._birthyear = birthyear
    
    def setName(self, val):
        self._name = val
    def setBrithyear(self, val):
        self._birthyear = val

    def getName(self):
        return self._name
    def getBirthyear(self):
        return self._birthyear