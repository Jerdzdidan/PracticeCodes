# great_places = ["silicon valley", "paris", "japan", "rome", "mars"]
#
# print(great_places)
#
# print("")
#
# print(sorted(great_places))
# print(sorted(great_places, reverse = True))
#
# print("")
#
# print(great_places)
#
# print("")
#
# great_places.reverse()
# print(great_places)
# great_places.reverse()
# print(great_places)
#
# print("")
#
# great_places.sort()
# print(great_places)
# great_places.sort(reverse = True)
# print(great_places)



movies = ["toy story", "the dark knight", "joker", "the mitchells vs the robots", "avengers", "snyder's cut", "klaus", "ice age"]

print(f"My favorite movie is {movies[0].title()}")
print(f"My second favorite is {movies[-7].title()}\n")
movies[3] = "Soul"
print(f"{movies}\n")
movies.append("the lion king")
print(f"{movies}\n")
movies.insert(5, "coco")
print(f"{movies}\n")
del(movies[6])
print(f"{movies}\n")
popped_it = movies.pop(2)
print(f"{popped_it.title()} was a great movie")
print(f"{movies}\n")
good_movie = "klaus"
movies.remove(good_movie)
print(f"{movies}\n")
print(f"\n{movies}\n")
print(sorted(movies))
print(f"{sorted(movies, reverse = True)}")
print(f"{movies}\n")
movies.reverse()
print(f"{movies}")
movies.reverse()
print(f"{movies}\n")
movies.sort()
print(f"{movies}")
movies.sort(reverse = True)
print(f"{movies}\n")

print(f"Movie count: {len(movies)}\n")
