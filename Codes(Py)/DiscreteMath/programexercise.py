input_number = int(input("Enter a number: "))

if input_number > 0:
    print(f"\n1. {input_number} is Positive")
elif input_number < 0:
    print(f"\n1. {input_number} is Negative")
else: 
    print(f"\n1. {input_number} is Zero")

if input_number != 0: 
    if input_number % 2 == 0:
        print(f"2. {input_number} is Even")
    else:
        print(f"2. {input_number} is Odd")
else:
    print("2. Zero is neither odd nor even.")

if input_number != 0:  
    if input_number > 0:
        print(f"3. Multiples of {input_number} until 50:")
        multiples = [i for i in range(input_number, 51, input_number)]
    else:
        print(f"3. Multiples of {input_number} until -50:")
        multiples = [i for i in range(input_number, -51, input_number)] 
    
    print("  ", multiples)
else:
    print("Multiples of zero are not defined.")
