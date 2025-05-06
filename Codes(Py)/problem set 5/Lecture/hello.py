def hello(to="world"):
    return f"hello, {to}"

def main():
    name = input("What's your name? ")
    print(hello(name))