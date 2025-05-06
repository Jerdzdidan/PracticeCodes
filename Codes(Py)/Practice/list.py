print("")
names = ["Jennifer", "Olive", "Mary"]

print("Hello, Mommy ", names[0])
print("Hello, Tita ", names[1])
print("Hello, Tita ", names[-1])

company = []

company.append("apple")
company.append("spacex")
company.append("solar city")
company.append("stark industries")
company.append("pixar")
company.append("mcdonalds")
company.append("nintendo")
company.append("netflix")
company.append("paypal")
company.insert(0, "tesla")
company.insert(4, "ford")
company.insert(4, "coca Cola")
del company[-2:]
del(company[-1])
fictional_company = company.pop(6)

statement = f"The company that i would create would be like or greater than {company[0].title()}, {company[1].title()}, {company[2].title()}, and, {company[4].title()}"
print("")
print(statement)
print(company)
print(fictional_company)
print(f"{fictional_company.title()} is owned by Mr. Tony Stark himself")
print("")
