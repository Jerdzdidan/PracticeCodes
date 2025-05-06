def binary(n):
    if n == 0:
        return "0"
    
    binary_digits = []
    while n > 0:
        remainder = n % 2
        print(f"{n} / 2 = {n//2} r{remainder}")
        binary_digits.append(str(remainder))
        n //= 2
    
    binary_digits.reverse()
    return ''.join(binary_digits)

def octal(n):
    octal = 0
    while n > 0:
        remainder = n % 8
        print(f"{n} / 8 = {n//8} r{remainder}")
        octal = (octal * 10) + remainder
        n //= 8
    octal = str(octal)
    return octal[::-1]

def hexadecimal(n):
    hex_chars = '0123456789ABCDEF'
    hex_string = ''
    while n > 0:
        remainder = n % 16
        hex_string = hex_chars[remainder] + hex_string
        print(f"{n} / 16 = {n//16} r{n%16} = {hex_chars[remainder]}")
        n //= 16
    return hex_string if hex_string else '0'

def binary_to_decimal(binary_str):
    decimal = 0
    power = 0
    for digit in reversed(binary_str):
        decimal += int(digit) * (2 ** power)
        print(f"{digit} * (2 ** {power}) = {int(digit) * (2 ** power)}")
        power += 1
    return decimal

def octal_to_decimal(octal_str):
    decimal = 0
    power = 0
    for digit in reversed(octal_str):
        decimal += int(digit) * (8 ** power)
        print(f"{digit} * (8 ** {power}) = {int(digit) * (8 ** power)}")
        power += 1
    return decimal

def hexadecimal_to_decimal(hex_str):
    hex_chars = '0123456789ABCDEF'
    decimal = 0
    power = 0
    hex_str = hex_str.upper()
    for digit in reversed(hex_str):
        decimal += hex_chars.index(digit) * (16 ** power)
        print(f"{hex_chars.index(digit)} * (16 ** {power}) = {hex_chars.index(digit) * (16 ** power)}")
        power += 1
    return decimal

# num = int(input("Enter num: "))
# print()
# print(f"Binary number: {binary(num)}(b2)")
# print()
# print(f"Octal number: {octal(num)}(b8)")
# print()
# print(f"Hexadecimal number: {hexadecimal(num)}(b16)")

# binnum = input("Enter binary number: ")
# print()
# print(f"Binary to dec number: {binary_to_decimal(binnum)}(b10)")
# print()
# octalnum = input("Enter octal number: ")
# print(f"Octal to dec number: {octal_to_decimal(octalnum)}(b10)")
# print()
hexnum = input("Enter hexadecimal number: ")
print(f"Hexadecimal to dec number: {hexadecimal_to_decimal(hexnum)}(b10)")