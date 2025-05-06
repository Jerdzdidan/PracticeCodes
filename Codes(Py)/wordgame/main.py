import json
import requests

def get_word():
    response = requests.get("https://random-word-api.herokuapp.com/word")
    o = response.json()
    word = o[0]

    return word.lower()

def draw_game(word, guesses, lives):
    output = []
    for letter in word:
        if letter in guesses:
            output.append(letter)
        else:
            output.append("?")
    print(output)

    print("Lives left: ", end="")
    print("❤ " * lives)


LIVES = 9
WORD = get_word()

def main():
    word = [letter for letter in WORD]
    lives = LIVES
    guesses = []

    while True:
        draw_game(word, guesses, lives)

        guess = input("\nGuess a letter or the whole word:").lower()

        if guess in guesses:
            print(f"\nYou already guessed: {guess}\n")
            continue
        else:
            guesses.append(guess)

        if guess == word:
            print("You guessed IT!!")
            break
        elif guess not in WORD:
            print("\nIncorrect you lose a life.\n")
            lives -= 1

        correct_guess = [letter if letter in guesses else "" for letter in word]
        if word == correct_guess:
            print("You guessed IT!")
            break
        elif lives <= 0:
            print("Sorry You lose!")
            print(f"The word was: {WORD}")
            break
        
        
        

if __name__ == "__main__":
    main()
