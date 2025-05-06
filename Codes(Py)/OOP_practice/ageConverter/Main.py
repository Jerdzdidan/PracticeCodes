from AnimalZodiac import AnimalZodiac

person = AnimalZodiac("Jerdan L. Gondayao", 2004, 2024)

person.computeAge()
person.convertAgeInMonths()
person.convertAgeInDays()
person.convertAgeInHours()
person.convertAgeInMinutes()
person.convertAgeInSeconds()
person.evaluateAnimalZodiac()

print("Year today:", person.getYearToday())
print("Name:", person.getName())
print("Birth Year:", person.getBirthyear())
print("Animal Zodiac Sign:", person.getAnimalZodiac())
print("\nAge:", person.getAge())
print("Age in months:", person.getAgeInMonths())
print("Age in days:", person.getAgeInDays())
print("Age in hours:", person.getAgeInHours())
print("Age in minutes:", person.getAgeInMinutes())
print("Age in seconds:", person.getAgeInSeconds())