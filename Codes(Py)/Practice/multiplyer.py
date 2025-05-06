# n = 0
# m = 0
# while n <= 10:
#     print(m)
#     m += 2
#     n += 1

# for n in range(20):
#     if n % 2 == 0:
#         print(n, end = " ")
#     else:
#         print("ODD", end = " ")

# for x in range(1,31):
#     if x % 2 == 1:
#         print (x, end = " ")
#     else:
#         print ("Even", end = " ")

# def count(numbers):
#     total = 0
#     for n in numbers:
#         if n < 20:
#             total += 1
#     return total
# list = [1,2,3,4,5,6,7,8,9,20,30,40,30,20,30,40]
# print(count(list))

# prices = {
#     "box_of_spaghetti" : 4,
#     "lasagna" : 5,
#     "hamburger" : 2
# }
# quantity = {
#     "box_of_spaghetti" : 6,
#     "lasagna" : 10,
#     "hamburger" : 0
# }
#
# money_spent = 0
#
# for n in prices:
#     money_spent = money_spent + (prices[n] * quantity[n])
#
# print(money_spent)

# Prices below 5
# prices = {
#     "box_of_spaghetti" : 4,
#     "lasagna"  : 5,
#     "hamburger" : 2
#    }
# quantity = {
#     "box_of_spaghetti" : 6,
#     "lasagna"  : 10,
#     "hamburger" : 0
#     }
#
# money_spent = 0
#
# for n in prices:
#     if prices[n] < 5:
#         money_spent += prices[n] * quantity[n]
#     else:
#         money_spent = money_spent
#
# print(money_spent)

# Prices above 5
# prices = {
#     "box_of_spaghetti" : 4,
#     "lasagna"  : 5,
#     "hamburger" : 2
#    }
# quantity = {
#     "box_of_spaghetti" : 6,
#     "lasagna"  : 10,
#     "hamburger" : 0
#     }
#
# money_spent = 0
#
# for n in prices:
#     if prices[n] >= 5:
#         money_spent += prices[n] * quantity[n]
#     else:
#         money_spent = money_spent
#
# print(money_spent)
