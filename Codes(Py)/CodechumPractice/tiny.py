index = int(input("Number of items: "))

items_input = input("Items: ")

items = items_input.split()

items = [int(item) for item in items]

smallest = items[0]
for item in items:
    if item <= smallest:
        smallest = item

print("Smallest = ", smallest)