import sys

# System exit in order to exit the program if the input is not acquired
if len(sys.argv) < 2:
    sys.exit("too few arguments")
elif len(sys.argv) > 2: 
    sys.exit("too many arguments")

print("hello, my name is", sys.argv[1])