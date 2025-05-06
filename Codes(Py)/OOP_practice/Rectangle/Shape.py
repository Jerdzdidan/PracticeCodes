class Shape:
    def __init__(self, data1, data2):
        self._data1 = data1
        self._data2 = data2
    
    def setData1(self, value):
        self._data1 = value
    def setData2(self, value):
        self._data2 = value

    def getData1(self):
        return self._data1
    def getData2(self):
        return self._data2