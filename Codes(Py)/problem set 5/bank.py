def greet(greeting):
    greeting = greeting.lower().strip()
    if "hello" in greeting:
        return 100
    elif "h" in greeting[0]:
        return 20
    else:
        return 0

def main():
    greeting = input("Greeting: ")
    print(greet(greeting))

if __name__ == "__main__":
    main()