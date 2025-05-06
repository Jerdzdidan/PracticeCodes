print("")
print("mc_comands by jerdan:")
while True:
    command = input("")
    if command == "/help":
        print("command list:\n /gamemode\n /help\n /op\n /give\n /time\n /spawnpoint\n")
        break
    elif command == "/gamemode 1":
        print("User is now in creative mode\n")
        break
    elif command == "/gamemode 0":
        print("User is now in survival mode\n")
        break
    elif command == "/op":
        print("User is now an operator\n")
        break
    elif command == "/give steak 64":
        print("User recieved 64 steaks\n")
        break
    elif command == "/time day":
        print("Time set to day\n")
        break
    elif command == "/spawnpoint":
        print("Spawnpoint set\n")
        break
    else:
        print("Invalid command use /help to see the command list\n")
        break
