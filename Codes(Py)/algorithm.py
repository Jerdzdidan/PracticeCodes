# DECLARATIONS
input_number_of_minutes = 0
number_of_seconds_in_a_minute = 60

# INPUT
input_number_of_minutes = input("\nEnter the number of minutes: ")

# CONSTRAINTS
if input_number_of_minutes.isdigit() == False:
    exit()
else:
    input_number_of_minutes = int(input_number_of_minutes)

# PROCESS
number_of_seconds_in_the_inputted_number_of_minutes = input_number_of_minutes * number_of_seconds_in_a_minute

# OUTPUT
print(f"\nSOLUTION: Number of seconds in {input_number_of_minutes} minutes = {input_number_of_minutes} minutes * {number_of_seconds_in_a_minute}\n")
print(f"RESULT: {input_number_of_minutes} minutes = {number_of_seconds_in_the_inputted_number_of_minutes} seconds\n")