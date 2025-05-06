def main():
    time = input("What time is it? ")
    time = convert(time)
    if time >= 7 and time <= 8:
        print("Breakfast Time!")
    elif time >= 12 and time <= 13:
        print("Lunch Time!")
    elif time >= 18 and time <= 19:
        print("Dinner Time")
    else:
        print("No eating you fatty")

def convert(time):
    time = hours, minutes = time.split(":")
    hours = float(hours) + (float(minutes) / 60)
    return hours
    

if __name__ == "__main__":
    main()