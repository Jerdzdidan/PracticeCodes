address_input = input("Enter address: ")

address_parts = [part.strip() for part in address_input.split(',')]

if len(address_parts) != 3:
    print("Invalid input format. Please provide address in the format: Barangay, Town, Province ZipCode.")
else:
    barangay = address_parts[0]
    town = address_parts[1]
    province_info = address_parts[2]

    if ' ' in province_info:
        province, zipcode = province_info.rsplit(' ', 1)
    else:
        province = province_info
        zipcode = ''

    print("Barangay:", barangay)
    print("Town:", town)
    print("Province:", province)

    if zipcode and len(zipcode) >= 4:
        print("Zip Code:", zipcode)
    else:
        print("Zip Code: Not provided")
