survey = []
while True:
    question = input("Do you like robots? Yes or No: ")
    question = question.lower()
    if question == "yes" or question == "no":
        survey.append(question)
    else:
        print("Error message the only inputs we take is YES and NO")

    yes = survey.count("yes")
    no = survey.count("no")

    print(f"Number of Yes answers: {yes}")
    print(f"Number of No answers: {no}")
