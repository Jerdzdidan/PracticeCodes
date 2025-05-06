file_name = input("File name: ")

if ".gif" in file_name or ".jpeg" in file_name or ".jpg" in file_name or ".png" in file_name:
    print("image/gif")
elif ".pdf" in file_name:
    print("application/pdf")
elif ".txt" in file_name:
    print("text/plain")
elif ".zip" in file_name:
    print("application/zip")
else:
    print("File Unknown")