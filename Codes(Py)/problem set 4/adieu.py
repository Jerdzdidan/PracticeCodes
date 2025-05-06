import inflect
p = inflect.engine()

adieu = "Adieu, adieu, to "
list_of_names = []

try:
    while True:
        myinput = input("Name: ")
        list_of_names.append(myinput)
except EOFError:
    mylist = p.join((list_of_names), final_sep="")
    print(adieu + mylist)