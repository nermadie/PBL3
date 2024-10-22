# PBL3: MOVIES TICKET BOOKING SYSTEM (Windows Form Application)

## Team Members (Da Nang University of Science and Technology)

1. 102200311 - Trần Nhật Minh
2. 102200308 - Trần Đinh Gia Khiêm
3. 102200296 - Lê Tiến Đạt
4. 102200350 - Võ Tri Phúc

## Description

This project is a Windows Form Application that simulates a movie ticket booking system. The application allows users to view movie information, check showtimes, book tickets, and view booking history.

The application also provides an admin interface for managing movies, showtimes, and bookings. And it also provides interface for staff to check and manage bookings.

## Features

### User Interface

- **Home Page**: Display the list of movies that are currently showing.
  ![alt text](images\image-1.png)
- **Movie Detail Page**: Display detailed information about a movie, including the title, description, poster, and showtimes.
  ![alt text](images\image-2.png)
- **Showtime Page**: Display the showtimes of a movie.
  ![alt text](images\image.png)
- **Booking Page**: Allow users to book tickets for a showtime.
  ![alt text](images\image-3.png)
- **Booking History Page**: Display the booking history of the user.
  ![alt text](images\image-4.png)
- **Admin Interface**: Allow admin to manage movies, showtimes, and bookings.
- **Staff Interface**: Allow staff to check and manage bookings.

### Database

![alt text](images\image-5.png)

### Technologies

- **Frontend**: C# Windows Form Application
- **Backend**: C# .NET Framework
- **Database**: Microsoft SQL Server

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/nermadie/PBL3.git
   ```

2. Install the required packages:

   - Microsoft C++ Build Tools: [Download](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - Find path to msbuild.exe `(e.g. C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin\MSBuild.exe)` and add it to PATH
   - Microsoft SQL Server: [Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
   - Make sure you change the connection string in `App.config` to your SQL Server connection string and create the database with the name `QLRapChieuPhim` before running the application.
   - The Program will automatically create the tables and seed the data when you run the application for the first time.
   - .NET Framework 4.8: [Download](https://dotnet.microsoft.com/download/dotnet-framework/net48)
   - Install required fonts in the `Fonts` folder.

3. Build the project (inside the project folder):
   ```bash
    msbuild
   ```
4. Run the application:
   ```bash
    cd PBL3\bin\Debug
    PBL3.exe
   ```
