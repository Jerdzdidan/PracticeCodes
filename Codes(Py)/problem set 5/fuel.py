def main():
    fraction = input("Fraction: ")
    print(convert(fraction))

def convert(fraction):
    try:
        x,y = fraction.split("/")
    except AttributeError:
        return "Error"
    x = int(x)
    y = int(y)
    try:
        z = x / y
    except ZeroDivisionError:
        return "Error"

    return gauge(z)

def gauge(percentage):
    percentage = percentage * 100

    if percentage >= 99:
        return "F"
    elif percentage < 99 and percentage > 1:
        return f"{int(percentage)}%"
    elif percentage <= 1:
        return "E"
    else:
        pass


if __name__ == "__main__":
    main()