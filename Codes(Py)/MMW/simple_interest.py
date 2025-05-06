from math import ceil

print()
i = float(input("I: ").replace(",", ""))

p = float(input("P: ").replace(",", ""))

r = input("r: ").replace("%", "")

r = float(r)
r = r / 100

t = input("t: ")
if t != "0":
    t, is_month = t.split(" ")
    t = int(t)
    if is_month == "mos":
        t /= 12
else:
    t = int(t)

if i == 0:
    i = (p * r) * t
    print(f"\nI = {p:,} * {r} * {t}")
    print(f"I = {i:,}")
elif p == 0:
    p = i / (r * t)
    print(f"\nP = {i:,} / ({r} * {t:.2f})")
    print(f"P = {p:,}")
elif r == 0:
    r = i / (p * t)
    print(f"\nR = {i:,} / ({p:,} * {t:.2f})")
    print(f"R = {r * 100}%")
elif t == 0:
    t = i / (p * r)
    print(f"\nT = {i:,} / ({p:,} * {r:.4f})")
    print(f"T = {t:.3f} yrs")

f = p + i
print(f"\nF = {p:,} + {i:,}")
print(f"F = {f:,}\n")