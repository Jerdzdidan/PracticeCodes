import json
import requests
import sys

response = requests.get("https://api.coindesk.com/v1/bpi/currentprice.json")
o = response.json()
bpi = o['bpi']
usd = bpi['USD']
rate_float = usd['rate_float']

if len(sys.argv) != 2:
    # print("Missing command-line argument")
    # sys.exit()
    try:
        input = float(input("Input: "))
        product = rate_float * input
        print(f"${product:,.2f}")
    except requests.RequestException:
        print("Command-Line argument is not a number")   


if len(sys.argv) == 2:
    try:
        n = float(sys.argv[1])
        product = rate_float * n
        print(f"${product:,.2f}")
    except requests.RequestException:
        print("Command-Line argument is not a number")    