print()
p = float(input("P: ").replace(",", ""))

r = input("r: ").replace("%", "")

r = float(r)
r = r / 100

t = input("t: ")
if t != "0":
    t, is_month = t.split(" ")
    t = float(t)
    if is_month == "mos":
        t /= 12
else:
    t = float(t)

n = 0

m = input("Is it (annually/monthly/semi-annually/quarterly): ")
if m == "annually":
    n = 1
elif m == "monthly":
    n = 12
elif m == "semi-annually":
    n = 2
elif m == "quarterly":
    n = 4

a = p*((1 + (r / n))**(n*t))

print(f"\nA = {p} * ((1 + ({r} / {n}) ** ({n} * {t}))")
print(f"Compound interest = {a:.2f}\n")