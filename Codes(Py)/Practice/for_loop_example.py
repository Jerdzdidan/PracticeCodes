scores = [13, 32, 23, 27, 19, 10]
player = [1, 2, 3, 4, 5, 6]
for score in scores:
    print(f"Player {player.pop(0)} score: ", score)
print("That's IT!!!")

scores = [13, 32, 23, 27, 19, 10]
for n in [1, 2, 3, 4, 5, 6]:
    print(f"Player {n} score: ", scores.pop(0))

large_number = -1
for i in [1, 8, 32, 47, 64, 69, 81, 21, 27 ,54, 65, 75, 2]:
    if i > large_number:
        large_number = i
print(large_number)


list = [1, 8, 32, 47, 64, 69, 81, 21, 27 ,54, 65, 75, 2]
print(max(list))
