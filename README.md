![enter image description here](https://i.ibb.co/Btp2PHB/GOBilet.png)

**GOBilet** - This is an example application that features a flight ticket purchasing system with an admin panel and a Check-In module, developed using C# WinForms. Initially released in June 2022 in the Turkish language, I subsequently created an English version in September 2023. The English version was implemented without making any modifications to the underlying code, except for the front-end string translations. Both releases can be accessed in the Releases section of this repository.

# Home Page (Ana Sayfa)
The home page serves as the initial interface upon opening the program. It allows you to search for flight tickets by providing specific details such as departure and arrival airports, departure and return dates, selecting between one-way or round-trip options, and specifying the number of passengers.
![enter image description here](https://i.ibb.co/bXNkDRt/Ana-Sayfa.jpg)

# User Log-In (Kullanıcı Girişi)
To register and log in as a user, simply click on the login button located in the top right corner of the main page. From there, you will be prompted to provide your email and password for registration. Once registered, you can then log in using the same credentials.
![enter image description here](https://i.ibb.co/nrG55y8/Giri.jpg)

## Administration Panel (Yönetim Paneli)
The administration panel allows you to access and modify the available airports, meal options, and numbers. Using the "Add Airport/Meal Options" function, you can either add new airport/meal options or delete the selected ones from the respective lists. Once the desired changes have been made, you can simply click on the "Confirm Changes" button to finalize the process.

Admin Log-In Details:<br>
**E-Mail:** admin@admin.com<br>
**Password:** admin1234
![enter image description here](https://i.ibb.co/w6x8c9g/Admin-Paneli.jpg)

# Flight Search (Uçuş Araması)
On the Home Page, you have the option to search for a flight ticket by entering your desired information and clicking the "Find Flight Ticket" button. If you prefer to choose a destination randomly, you can utilize the "Random" button to generate a random destination for your flight search.
![enter image description here](https://i.ibb.co/Jtnmkct/Rastgele.jpg)

# Flight Selection (Uçuş Seçimi)
The flight search process is conducted randomly, presenting you with three options to choose from. Once you select a flight, it will be displayed in a 3D format. If you have chosen a one-way ticket, you can proceed to the next screen. However, if you have not selected the "One Way" option, you will have the choice to either select the return ticket using the "Select Return Ticket" button or return to the main screen by clicking the "Back" button located in the top right corner.
![enter image description here](https://i.ibb.co/nP2kVnb/D-n-U-u-u-Se-imi.jpg)

# Passenger Info (Yolcu Bilgileri)
The fields on the form will be dynamically activated based on the passenger information entered during the flight search. You can proceed by providing the name, surname, date of birth, and TR Identity Numbers of the respective passengers. You have the option to select Business Class, specify Meal Selection, Flight Set preferences, and choose Airbus Model extras. The flight price along with the cost of selected extras will be displayed separately. Once you have completed the necessary information, you can proceed to the payment screen by clicking the "Make Payment" button.
![enter image description here](https://i.ibb.co/MgGq887/Yolcu-Bilgileri-Giri-i.jpg)

# Payment Screen (Ödeme Ekranı)
Upon entering the card number, expiration date, CVC or CVC2, and any applicable coupon code, you can finalize the payment by selecting the "Make Secure Payment" button. In the case of a valid coupon, the total amount will be adjusted accordingly. Once the payment is successfully completed, a unique PNR (Passenger Name Record) number will be generated for your reservation.
![enter image description here](https://i.ibb.co/FVLMgqZ/deme-Ekran.jpg)
![enter image description here](https://i.ibb.co/b65RL57/deme-Ba-ar-l.jpg)

# Online Check-In
To perform the check-in process, you need to enter the PNR number of the ticket you have purchased. You can find the PNR number of your most recent ticket at the bottom of the Check-In screen in GOBilet. Simply copy the PNR number displayed there and paste it into the reservation (PNR) number field located above. Afterward, click the "Check-In" button to proceed with the check-in process. Alternatively, you can access the Check-In screen directly from the home page.<br>
![enter image description here](https://i.ibb.co/MpwF4hH/Online-Check-In.jpg)

# Boarding Pass (Biniş Kartı)
Once you have completed the check-in process, your boarding pass will be presented on the screen. It will contain essential details such as passenger information and flight information. If you have a return flight, you can access your other boarding pass by clicking on the "Return Pass" option located in the upper right corner of the screen. This will allow you to view the boarding pass for your return journey.
![enter image description here](https://i.ibb.co/HhgfvTd/Boarding-Pass.jpg)
![enter image description here](https://i.ibb.co/M11MM1H/Boarding-Pass-D-n.jpg)

### Info
Please note that all data within the program is randomly generated and does not reflect real-world information. It has been created solely for the purpose of demonstrating the implementation of a flight ticket purchasing system in WinForms. The data is not intended to represent actual flights, passenger details, or any other real-world information.
