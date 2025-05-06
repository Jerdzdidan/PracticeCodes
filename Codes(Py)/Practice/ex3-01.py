while True:
    print("")
    try:
        hours_worked = input("Enter Hours: ")
        hours_worked = float(hours_worked)
        rate_of_pay = input("Enter Rate: ")
        rate_of_pay = float(rate_of_pay)

    except:
        print("ERROR, Wrong Input. Maybe you didn't put a number.")

    if type(hours_worked) == float and type(rate_of_pay) == float:
        pay = hours_worked * rate_of_pay
        print("Pay:", pay)

    if hours_worked > 40.0:
        ov =  (hours_worked) * (rate_of_pay)
        otp = (hours_worked - 40) * (rate_of_pay * 0.5)
        ot = ov + otp
        print("Overtime Pay:", ot, "\n")
