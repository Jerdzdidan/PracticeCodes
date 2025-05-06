# Straight Commision Calculator
# commision_percent = 20 / 100
# ref = 12000
# tv = 7000
# heater = 1500
# total_sold = ref + tv + heater
#
# income = (total_sold * commision_percent)
# print(income)


# Salary Plus Commsion Calculator
# work_pay = 2000
# commision_over_20k = 20 / 100
# sold = 26000
#
# income = (26000 * commision_over_20k) + work_pay
# print(income)


# Graduated Commision Calculator
# commision = 0
# sold = 0
#
# while sold < 70000:
#     commision += 1
#     sold += 10000
#     commision_percent = commision / 100
#     income = (sold * commision_percent)
#     print(f"Total sold: {sold}Php\nTotal income: {int(income)}Php")



# cellphone_sold = 10
# cash_per_cp = 18000
# commision = 2.0
# commision_percent = commision / 100
# total_sold = (cellphone_sold * cash_per_cp)
# income = 0
# i = 1
# total_income = 0

# Computing Commision on Cash Basis
# income = total_sold * commision
# print(income)

# Computing Commision on Installment Basis
# while i < 7:
#     income = total_sold * commision_percent
#     print(f"Income for month {i}: {round(income, 1)}")
#     commision = commision - 0.30
#     commision_percent = commision / 100
#     cash_per_cp -= 3000
#     total_sold = (cellphone_sold * cash_per_cp)
#     i += 1
#     total_income += income
#
# print(f"\nTotal income: {total_income}\n")

# 1
# monthly_pay = 15000
# commision = 7
# commision_percent = 7 / 100
# sold = 130000
#
# salary = (sold * commision_percent) + 15000
# print(salary)


# 2
# monthly_pay = 17500
# sold = 850000
# commision_450k = 5 / 100
# commision_over_450k = 6 / 100
# sale_450k = (sold - 400000) * commision_450k
# sale_over_450k = (sold - 450000) * commision_over_450k
#
# income = monthly_pay + sale_450k + sale_over_450k
# print(income)


# 3

sold = 42000
interest = 4
interest_rate = interest / 100
month = 4
buyer_pay_per_month = (sold + sold * interest_rate) / month
commision = 5.5
commision_percent = commision / 100
income = 0



for i in range(1, 5):
    income = buyer_pay_per_month * commision_percent
    commision -= .5
    commision_percent = commision / 100
    print(f"Income in month {i}: {round(income, 1)}")
