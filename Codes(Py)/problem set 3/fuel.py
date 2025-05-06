def main():
    get_gauge()

def get_gauge():
    while True:
        try:
            x,y = input("Fraction: ").split("/")
            x = int(x)
            y = int(y)
            z = x / y

            if z == 1:
                print("F")
            elif z == 0.75:
                print("75%")
            elif z == 0.50:
                print("50%")
            elif z == 0.25:
                print("25%")
            elif z == 0:
                print("E")
            else:
                pass
        except (ValueError, ZeroDivisionError):
            pass


main()