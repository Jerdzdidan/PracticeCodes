def main():
    the_answer = input("What is the Answer to the Great Question of Life, the Universe, and Everything?: ")
    answer(the_answer)

def answer(n):
    if n == "42" or n == "forty-two" or n == "forty two":
        print("Yes")

main()