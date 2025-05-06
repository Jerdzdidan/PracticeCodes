from math import ceil

print()
d = float(input("D: ").replace(",", ""))

m = float(input("M: ").replace(",", ""))

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

if m == 0 and d == 0:
    m = p / (1-(r*t))
    print(f"\nM = {p}/ 1 - {r} * {t:.2f}")
    print(f"M = {m:,.2f}")

if d == 0:
    d = (m * r) * t
    print(f"\nD = {m:,} * {r} * {t:.2f}")
    print(f"D = {d:,.2f}")
elif m == 0:
    m = d / (r * t)
    print(f"\nM = {d:,} / ({r} * {t:.2f})")
    print(f"M = {m:,.2f}")
elif r == 0:
    r = d / (m * t)
    print(f"\nR = {d:,} / ({m:,} * {t:.2f})")
    print(f"R = {r * 100}%")
elif t == 0:
    t = d / (m * r)
    print(f"\nT = {d:,} / ({m:,} * {r:.4f})")
    print(f"T = {ceil(t)} yrs")

if p == 0:
    p = m - d
    print(f"\nP = {p:,.2f} - {d:,.2f}")
    print(f"Proceeds = {p:,.2f}\n")