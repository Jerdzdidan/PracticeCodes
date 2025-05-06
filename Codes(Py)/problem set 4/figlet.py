import random
import sys
from pyfiglet import Figlet

figlet = Figlet()
list = figlet.getFonts()

if len(sys.argv) < 2:
    figlet.setFont(font = random.choice(list))
elif (sys.argv[1] == "-f" or sys.argv[1] == "--font"):
    if sys.argv[2] in list:
        figlet.setFont(font = sys.argv[2])
    else:
        sys.exit("Invalid usage")
else:
    sys.exit("Invalid usage")

input = input("Input: ")

print("Output: ")
print(figlet.renderText(input))