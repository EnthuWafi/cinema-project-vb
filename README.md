# cinema-project-vb

For UiTM CSC248, our group had decided to create a Cinema Ticketing System for our final assignment.
## Purposes for the Application
The purpose of this application to help simplify the daily operation of GTA CINEMA, both for the customers and the cinema employees.

## Tools Used
- Microsoft Access
- Microsoft Visual Studio 2017
- VB.NET Framework 4.6.1

## Features
#### User-friendly GUI for both the customer and cinema employees.
- Makes it easy to purchase tickets
#### Every information is stored within a database
- With the exception of movie images, pretty much every information is stored in the database
#### Printing receipt and tickets
- Prints out the information in a nice and orderly way

## Possible future features
- Filtering movies by genre
- Remove movies and showtimes from the database with a click
- Movie Images stored within Access database rather than VB.NET Resources file
- Able to choose and add Movie Images when creating new Movie (must store images in database first)

## Common errors
### Database is not found?
- Locate and double-click App.config
- Within the first connectionString, find the path specified after "Data Source=\&quot;"
- Replace or modify the path for the connection to your current cinemadb.accdb path (found in the project folder)
- It should work now, else please contact me.
