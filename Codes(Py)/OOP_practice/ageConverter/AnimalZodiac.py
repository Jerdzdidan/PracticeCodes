from AgeConverter import AgeConverter

class AnimalZodiac(AgeConverter):
    def __init__(self, name, birthYear, yearToday):
        super().__init__(name, birthYear, yearToday)
    
    def evaluateAnimalZodiac(self):
        if self.getBirthyear() % 12 == 0:
            self._animalZodiac = "Monkey"
        elif self.getBirthyear() % 12 == 1:
            self._animalZodiac = "Rooster"
        elif self.getBirthyear() % 12 == 2:
            self._animalZodiac = "Dog"
        elif self.getBirthyear() % 12 == 3:
            self._animalZodiac = "Pig"
        elif self.getBirthyear() % 12 == 4:
            self._animalZodiac = "Rat"
        elif self.getBirthyear() % 12 == 5:
            self._animalZodiac = "Ox"
        elif self.getBirthyear() % 12 == 6:
            self._animalZodiac = "Tiger"
        elif self.getBirthyear() % 12 == 7:
            self._animalZodiac = "Rabbit"
        elif self.getBirthyear() % 12 == 8:
            self._animalZodiac = "Dragon"
        elif self.getBirthyear() % 12 == 9:
            self._animalZodiac = "Snake"
        elif self.getBirthyear() % 12 == 10:
            self._animalZodiac = "Horse"
        elif self.getBirthyear() % 12 == 11:
            self._animalZodiac = "Sheep"
        else:
            self._animalZodiac = "Invalid"
        
    def getAnimalZodiac(self):
        return self._animalZodiac