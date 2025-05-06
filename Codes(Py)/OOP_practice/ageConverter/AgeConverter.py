from Person import Person

class AgeConverter(Person):
    def __init__(self, name, birthYear, yearToday):
        super().__init__(name, birthYear)
        self._yearToday = yearToday
    
    def setYearToday(self, val):
        self._yearToday = val
    
    def computeAge(self):
        self._age = self._yearToday - self.getBirthyear()
    
    def convertAgeInMonths(self):
        self._ageMonths = self._age * 12
    def convertAgeInDays(self):
        self._ageDays = self._ageMonths * 30
    def convertAgeInHours(self):
        self._ageHours = self._ageDays * 24
    def convertAgeInMinutes(self):
        self._ageMinutes = self._ageHours * 60
    def convertAgeInSeconds(self):
        self._ageSeconds = self._ageMinutes * 60

    def getYearToday(self):
        return self._yearToday
    def getAge(self):
        return self._age
    def getAgeInMonths(self):
        return self._ageMonths
    def getAgeInDays(self):
        return self._ageDays
    def getAgeInHours(self):
        return self._ageHours
    def getAgeInMinutes(self):
        return self._ageMinutes
    def getAgeInSeconds(self):
        return self._ageSeconds