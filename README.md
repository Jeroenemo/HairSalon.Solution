# Order Tracker

#### A Simple Database Application

#### By Jeroen van Seeters

## Technologies Used

* C#
* .Net 5.0
* Asp.Net Core
* Razor
* Entity Core
* MySql
* REPL
* Git and GitHub

## Description

This is a basic application designed to dipslay my grasp on database basics, using a one to many relationship. In this application, a user can add stylists to a list, and attribute clients to the stylist. and  This application was created with the guidance of **EPICODUS**, the greatest coding bootcamp in the known universe, and google.

## Setup/Installation Requirements

**Set up the Application:**
* You need to have .net 5.0 installed on your machine in order to run this program. You can find the download [here](https://dotnet.microsoft.com/download/dotnet/5.0)
* Clone the repository from GitHub using `git clone https://github.com/Jeroenemo/HairSalon.Solution.git`
* Navigate to the downloaded folder using the cd command
* * Navigate down one level into the HairSalon directory. `cd HairSalon`
* Create an appsettings.json file in the HairSalon directory. `touch appsettings.json`
* Add the following code to your appsettings.json file
* ```
    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
        }
    }
* Please note that the variables in brackets needs to be replaced with your own database name and password.
* Run a restore and build command. `dotnet restore` and `dotnet build`

**Set up the Database:**
* You need to have MySqlWorkbench installed on your machine.
* In the navigator > Administration window, select Data Import/Restore
* In Import Options select Import from Self-Contained File.
* Navigate to jeroen_van_seeters.sql in the HairSalon.Solutions directory
* Under Default Schema to be Imported To, select the New button.
* Enter the name of your database
* Click ok
* Click Start Import
* Reopen the Navigator > Schemas tab. Right click and select Refresh All. 

## Future Enhancements

* Make it look snazzy 
* Provide total of all orders
* Fix Individual Delete functionality in WIP branch
* Add update functionality 


## License

MIT

Copyright (c) 2021 Jeroen van Seeters

## Contact Information

Jeroen van Seeters vanseetersjeroen@gmail.com
