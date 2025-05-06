def main():
    try:
        core_values = input("CHIEFS: ")
        core_values = core_values.upper()

        if core_values == "C":
            print("C: Sufficient knowledge, understanding and skills that will enable him/her to act")
        elif core_values == "H":
            print("H: Being able to let go of oneself and be courteous and respectful of others")
        elif core_values == "I":
            print("I: Capability of doing the right thing in a reliable and upright manner because he/she has the wholeness of character.")
        elif core_values == "E":
            print("E: Attribute of looking at things in a fair andimpartial way towards all concerned, base on the principles of evenhanded dealing.")
        elif core_values == "F":
            print("F: Strength and courage to face adversity or difficulty")
        elif core_values == "S":
            print("S: Wise and responsible management of resources.")
        else:
            print("Input should be an alphabet between C, H, I, E, F, and S.")

    except ValueError:
        print("Input should be an alphabet between C, H, I, E, F, and S.")

main()