import cv2
import csv
import datetime

today = datetime.datetime.now()
# Capturing frame in cap variable
cap = cv2.VideoCapture(0)
# Creating detection function for QR Code
detection = cv2.QRCodeDetector()

previous_data = None  # To store previously scanned data

while True:
    while True:
        # Reading frame cap
        ret, frame = cap.read()
        # Decoding the frame for QR Code data
        data, box, point = detection.detectAndDecode(frame)
        # Printing frame
        cv2.imshow("QR Code Scanner", frame)
    
        if cv2.waitKey(1) & len(data) > 1:
            break
    
    # Checking if the same data was scanned again
    if data and data != previous_data:
        # Writing the QR Code data
        l1 = data.split(",")
        l1.append("P")
        l1.append(today)
        header = ['Name', 'Student_number','Course/Year/Section', 'Attendance', 'Date']
        
        with open('Attendance.csv', 'a+', encoding='UTF8', newline='\n') as f:
            writer = csv.writer(f)
            writer.writerow(l1)
        
        print(l1)
        previous_data = data  # Update previous data

cap.release()
cv2.destroyAllWindows()
