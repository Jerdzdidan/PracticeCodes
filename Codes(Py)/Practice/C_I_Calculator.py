print("")

while True:
    years = 0
    try:
        account = input("Initial investment: ")
        account = float(account)

        annual_investment = input("Annual Investment: ")
        annual_investment = float(annual_investment)

        interest_rate = input("Interest rate %: ")
        interest_rate = float(interest_rate)
        interest_rate /= 100.0

        years = input("Years of holding/investing: ")
        years = int(years)

        print("")

    except:
        if type(account) == str:
            print('"Error: Your input in Initial Investment is not a number"')
        elif type(annual_investment) == str:
            print('"Error: Your input in Annual Investment is not a number"')
        elif type(interest_rate) == str:
            print('"Error: Your input in Interest rate is not a number"')
        elif type(years) == str:
            print('"Error: Your input in Years of holding/investing is not a number"')
        else:
            print('"Error: Your input in Initial Investment is not a number"')

    counter = 1
    if type(years) == str:
        years = 0

    while counter <= years:
        accrued_interest = account * interest_rate
        account = account + accrued_interest
        format_account = round(account, 2)
        print(f"year {counter}: {format_account}")
        counter+=1
        account += annual_investment
    print("\n")
