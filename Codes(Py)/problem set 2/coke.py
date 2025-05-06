amount_due = 50
coin = 0

while amount_due > 0:
    print(f"\nAmount Due: {amount_due}")
    coin = input("Insert Coin: ")
    coin = int(coin)
    amount_due -= coin

    if amount_due <= 0:
        print("\nChange Owed", end=": ")
        print(abs(amount_due))
