grocerydict = {}

while True:
    try:
        item = input().lower()

        if item in grocerydict:
            grocerydict[item] += 1
        else:
            grocerydict[item] = 1

    # Use ctrl - Z in order to break/goto except
    except EOFError:
        for i in sorted(grocerydict.keys()):
            print(grocerydict[i], i.upper())
        break