import time

def precedence(op):
    if op == '+' or op == '-':
        return 1
    if op == '*' or op == '/':
        return 2
    return 0

def infix_to_postfix(expression):
    stack = []  # Stack to hold operators
    postfix = []  # List to hold the postfix expression
    i = 0
    while i < len(expression):
        char = expression[i]
        # If the character is a digit, capture the entire number
        if char.isdigit():
            num = char
            while i + 1 < len(expression) and expression[i + 1].isdigit():
                i += 1
                num += expression[i]
            postfix.append(num)
        # If the character is an operand, add it to the output list
        elif char.isalpha():
            postfix.append(char)
        # If the character is '(', push it to the stack
        elif char == '(':
            stack.append(char)
        # If the character is ')', pop and output from the stack until '(' is found
        elif char == ')':
            while stack and stack[-1] != '(':
                postfix.append(stack.pop())
            stack.pop()  # Pop '(' from the stack
        # If an operator is encountered
        else:
            while stack and precedence(stack[-1]) >= precedence(char):
                postfix.append(stack.pop())
            stack.append(char)

        # Handle multiplication if a variable is followed by '('
        if char.isalpha() and i + 1 < len(expression) and expression[i + 1] == '(':
            stack.append('*')  # Push multiplication operator to stack before '('

        i += 1

    while stack:
        postfix.append(stack.pop())

    return ''.join(postfix)  # Join without any spaces

def evaluate_postfix(postfix, variables):
    stack = []

    for token in postfix:
        if token.isalpha():  # If the token is a variable
            stack.append(variables[token])
        elif token.isdigit():  # If the token is a number
            stack.append(int(token))
        else:  # If the token is an operator
            b = stack.pop()
            a = stack.pop()
            if token == '+':
                stack.append(a + b)
            elif token == '-':
                stack.append(a - b)
            elif token == '*':
                stack.append(a * b)
            elif token == '/':
                stack.append(a / b)

    return stack[0]

def main():
    # Conversion infix to postfix
    infix_expression = input("Enter an infix expression: ").replace(" ", "").upper()
    postfix_expression = infix_to_postfix(infix_expression)
    print("Postfix expression:", postfix_expression)
    print()

    # Inputting values for characters
    variables = {}
    if any(char.isalpha() for char in postfix_expression):
        for char in postfix_expression:
            if char.isalpha() and char not in variables:
                # Strip any extra whitespace from user input
                variables[char] = float(input(f"Enter value for {char}: ").strip())

        # Substitute values into the postfix expression for display
        substituted_expression = ''.join(str(variables[char]).replace(".0", "")
                                          if char.isalpha() else char for char in postfix_expression)
        print("Postfix expression with values:", substituted_expression)
    
    time.sleep(.5)
    print("\nprocessing...\n")
    time.sleep(.8)
    # Evaluation of the postfix expression
    result = evaluate_postfix(postfix_expression, variables)
    print("The result of the expression is:", result)

main()
