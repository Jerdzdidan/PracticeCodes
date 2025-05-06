package = input("Enter package: ")
cubic_meter = int(input("Enter cubic meter used: "))

payment = 0
if package.upper() == "A":
    payment = 250 + (cubic_meter * 9.50)
elif package.upper() == "B":
    payment = 400
    cubic_meter-=20
    if cubic_meter > 0:
        payment += cubic_meter * 11.25
else:
    if cubic_meter > 25:
        payment += 750
    elif cubic_meter > 12:
        payment += 525
    else:
        payment += 750
    
print(f"Payment: {payment:.2f}")