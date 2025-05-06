# Guessing game
import random

# Input for the range of numbers to be generated
while True:
    try: 
        n = int(input("Level: "))
        if n > 0:
            break
    except ValueError:
        continue

# Initialization of the random number
ran_number = random.randint(1, n)

# Input for guessing the random number
while True:
    try: 
        guess = int(input("Guess: "))
        if guess > 0:
            if guess > ran_number:
                print("Too large!")
                continue
            elif guess < ran_number:
                print("Too small!")
                continue
            else:
                print("Just right!")
                break
    except ValueError:
        continue