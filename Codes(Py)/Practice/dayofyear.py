def day_number_of_year(date):
    year, month, day = map(int, date.split('-'))
    days_in_month = [0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334]
    day_number = days_in_month[month - 1] + day
    if month > 2 and year % 4 == 0 and (year % 100 != 0 or year % 400 == 0):
        day_number += 1
    return day_number

date = input("Enter the date (YYYY-MM-DD): ")
day_number = day_number_of_year(date)
print("Day number of the year:", day_number)
