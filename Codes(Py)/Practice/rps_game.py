player1 = 0
player2 = 0

while player1 <= 3 or player2 <= 3:
    player1_input = input("Input Player_1:").lower()
    player2_input = input("Input Player_2:").lower()

    if player1_input == 'rock' and player2_input == 'rock':
        print("It's a tie")
        print(f"Score player 1: {player1}")
        print(f"Score player 2: {player2}")
    elif player1_input == 'rock' and player2_input == 'paper':
        print("Player2 WINS!!")
        player2+=1
        print(f"Score player 1: {player1}")
        print(f"Score player 2: {player2}")
    elif player1_input == 'rock' and player2_input == 'scissors':
        print("Player1 WINS!!")
        player1+=1
        print(f"Score player 1: {player1}")
        print(f"Score player 2: {player2}")
    elif player1_input == 'paper' and player2_input == 'rock':
        print("Player1 WINS!!")
        player1+=1
        print(f"Score player 1: {player1}")
        print(f"Score player 2: {player2}")
    elif player1_input == 'paper' and player2_input == 'paper':
        print("It's a tie")
        print(f"Score player 1: {player1}")
        print(f"Score player 2: {player2}")
    elif player1_input == 'paper' and player2_input == 'scissors':
        print("Player2 WINS!!")
        player2+=1
        print(f"Score player 1: {player1}")
        print(f"Score player 2: {player2}")
    elif player1_input == 'scissors' and player2_input == 'scissors':
        print("It's a Tie")
        print(f"Score player 1: {player1}")
        print(f"Score player 2: {player2}")

if player1 > player2:
    print("Player 1 wins")
else:
    print("Player 2 wins")