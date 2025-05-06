# Function to define precedence of operators
def precedence(op):
    if op == '+' or op == '-':
        return 1
    if op == '*' or op == '/':
        return 2
    if op == '^':
        return 3
    return 0

# Function to check if the character is an operand (i.e., a letter or digit)
def is_operand(ch):
    return ch.isalpha() or ch.isdigit()

# Function to convert infix expression to postfix
def infix_to_postfix(expression):
    stack = []  # Stack to hold operators and parentheses
    result = []  # List to hold the postfix expression

    for ch in expression:
        # If the symbol is an operand, append it to result
        if is_operand(ch):
            result.append(ch)

        # If the symbol is '(', push it to the stack
        elif ch == '(':
            stack.append(ch)

        # If the symbol is ')', pop operators from stack until '(' is encountered
        elif ch == ')':
            while stack and stack[-1] != '(':
                result.append(stack.pop())
            stack.pop()  # Pop the '(' from the stack

        # If the symbol is an operator
        else:
            while stack and precedence(stack[-1]) >= precedence(ch):
                result.append(stack.pop())
            stack.append(ch)

    # Pop all the remaining operators from the stack
    while stack:
        result.append(stack.pop())

    # Convert list to string and return the postfix expression
    return ''.join(result)

# Input from user
expression = input("Enter the infix expression: ")
# Convert to postfix
postfix = infix_to_postfix(expression)
# Output the result
print("Postfix expression:", postfix)
