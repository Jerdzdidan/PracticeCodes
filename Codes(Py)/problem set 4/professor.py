# Math Game
import random

def main():
    problems = generate_integer(get_level())
    print(problems)

    score = 0
    n = 1
    while n <= 10:
        print()
        problem = problems[f"problem{n}"]
        x, y =problem.split('+')
        x, y = int(x), int(y)

        m = 0
        while True:
            if m == 3:
                print(f"{x} + {y} = {x+y}")
                break
            try:
                guess = int(input(f"Problem #{n}: {x} + {y} = "))
                if guess == x + y: 
                    score+=1
                    break
                else:
                    print("EEE")
                    m+=1
            except ValueError:
                print("EEE")
                m+=1
                continue
        n+=1
    
    print("\nScore:", score)
                
def get_level():
    while True:
        try: 
            n = int(input("Level: "))
            if n > 0 and n < 4:
                break
        except ValueError:
            continue

    return n

def generate_integer(level):
    problems = {}

    for i in range(10):
        x, y = random.randint(level, 10), random.randint(level, 10)
        problems.update({f"problem{i+1}":f"{x}+{y}"})
    
    return problems


if __name__ == "__main__":
    main()