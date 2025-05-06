list = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
]

while True:
    try:
        Date = input("Date: ")
        month, day, year = Date.split("/")
        month, day, year = int(month), int(day), int(year)
        if month <= 12 and day <= 31:
            print(f"{year}-{month:02}-{day:02}")
            break
        else:
            pass

    # Use ctrl - Z in order to break/goto except
    except ValueError:
        month, day, year = Date.split(" ")
        day, year = int(day.replace(",", "")), int(year)
        if month in list:
            x = list.index(month) + 1
        if x <= 12 and day <= 31:
            print(f"{year}-{x:02}-{day:02}")
            break
        else:
            pass
    else:
        pass