file = input("File name: ")

if ".gif" in file or ".jpg" in file or ".jpeg" in file or ".png" in file:
    print("img/gif")
elif ".pdf" in file:
    print("application/pdf")
elif ".txt" in file:
    print("text/plain")
elif ".zip" in file:
    print("application/zip")
else:
    print("unknown file")