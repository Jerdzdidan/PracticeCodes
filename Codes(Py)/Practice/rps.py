import random

n = 0

player_1 = 0
CPU = 0

print("")
while player_1 < 3 and CPU < 3:
    rps = input("Choose between rock, paper and scissors: ")

    if rps.lower() == "rock" or rps.lower() == "paper" or rps.lower() == "scissors":
        n = random.randint(1,3)

    else:
        print("'Error Command'")
        print("List of Commands: Rock, Paper, and scissors")


    if n == 1:
        n = "rock"

    elif n == 2:
        n = "paper"

    else:
        n = "scissors"

    print("")
    if rps.lower() == "rock" and n == "rock":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: Tie\n")

    if rps.lower() == "rock" and n == "paper":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: You Lose")
        CPU += 1
        print(f"CPU score: {CPU}\n")

    if rps.lower() == "rock" and n == "scissors":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: You Win!")
        player_1 += 1
        print(f"Your score: {player_1}\n")


    if rps.lower() == "paper" and n == "rock":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: You Win!")
        player_1 += 1
        print(f"Your score: {player_1}\n")

    if rps.lower() == "paper" and n == "paper":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: Tie\n")

    if rps.lower() == "paper" and n == "scissors":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: You Lose")
        CPU += 1
        print(f"CPU score: {CPU}\n")


    if rps.lower() == "scissors" and n == "rock":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: You Lose")
        CPU += 1
        print(f"CPU score: {CPU}\n")

    if rps.lower() == "scissors" and n == "paper":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: You Win!")
        player_1 += 1
        print(f"Your score: {player_1}\n")

    if rps.lower() == "scissors" and n == "scissors":
        print(f"You: {rps.title()}")
        print(f"CPU: {n.title()}")
        print("Result: Tie\n")



if CPU == 3:
    print(f"CPU wins the game by {CPU - player_1} points!\n")

if player_1 == 3:
    print(f"CPU wins the game by {player_1 - CPU} points!\n")
