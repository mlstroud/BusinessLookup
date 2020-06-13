   # _BusinessLookup API_

#### _Epicodus Project | Last Updated June 12, 2020_

#### By _**Matt Stroud**_

## Description
---
_An Epicodus individual project focused on software design with the MVC pattern in C#._  
_The API uses RESTful practices and connects to a MySql database via the Entity Framework._  

_The Business Lookup API can be used to find business information based on your query parameters._  
_The API Contains multiple versions, so be sure to view the documentation for full API support._  

**The database comes seeded with information for several businesses. Feel free to modify and add your own.**


## Specs
### Documentation
---
Once, you have followed the setup instructions below, visit the following URL to view the full API swagger documentation:
> https://localhost:5000/swagger
* Note: If you run the API on a different port, be sure to change the port number in the URL.
### API Endpoints v 1.0
---
| Endpoint Route                          | Method            | API Response                           |
|:----------------------------------------|:------------------|---------------------------------------:|
| /api/1.0/businesses                     | GET               | Returns all businesses.                |
| /api/1.0/businesses                     | POST              | Adds new business to dataabase.        |
| /api/1.0/businesses{id}                 | GET               | Returns business matching the id.      |
| /api/1.0/businesses{id}                 | PUT               | Updates business matching the id.      |
| /api/1.0/businesses{id}                 | DELETE            | Deletes business matching the id.      |

### API Endpoints v 2.0
---
| Endpoint Route                          | Method            | API Response                           |
|:----------------------------------------|:------------------|---------------------------------------:|
| /api/2.0/businesses                     | GET               | Returns businesses matching input queries.  |
| /api/2.0/businesses/random              | GET               | Returns random business.       |
| /api/2.0/businesses/search              | GET               | Returns business with name containing search string.     |

### Version Details
---
As you may have noticed, version 2.0 does not contain all of the endpoints that version 1.0 does.  
Please take care when submitting your API calls that you are using the correct version for the call you are making.  
Attempting to use the wrong version will result in a failed call.  
For example:  
> ...api/1.0/businesses/random  

Will result in a **400 Bad Request** error.  
> ...api/2.0/businesses/3  

Will result in a **404 Not Found** error.

### Querying
---
Version 2.0 supports querying for the default GET route.  
To use this you may enter one or several queries to the API call URL to filter the businesses that are returned.  
Below is a list of queries that may be used for the /api/2.0/businesses route.
> Note in the event of an empty query, it will default to return all businesses. If there are no matching results for your query, you will receive an empty result.

* **name** - Searches for businesses that are an exact match for the name,
* **category** - Searches for businesses that are an exact match for the category.
* **city** - Searches for businesses that are located in the specified city.

To use queries, adhere to the following format:
```
.../api/2.0/businesses?query=QUERYVALUE
```
Replace query with the query of your choice(name, category, city), and QUERYVALUE with the actual term you are looking for.  
To use multiple queries use the following format:
```
.../api/2.0/businesses?queryone=QUERYVALUE&querytwo=QUERYVALUE
```
You may add as many query values as you please, as long as they are valid.

### Making API Calls
---
Use the above endpoints and querying information when formatting your api calls.  
For the purpose of this API as delivered, use the following URL for submitting your API calls:
> https://localhost/api/version/businesses  

Replace version with the version number you are using (reference API Endpoints).  


For **POST** and **PUT** calls, you need to include an object literal in the body of your API call.
Below is the format for the notation you need to create or update a business. Please note all values are required.  
_For how to include this in your API call please refer to the documentation of the software you are using to make API calls as methods may vary._
```
{
  "name": "businessname",
  "category": "businesscategory",
  "description": "businessdescription",
  "address": "businessaddress",
  "openingtime": "businessopeningtime",
  "closingtime": "businessclosingtime"
}
```
> For opening closing time you must use the format HH:MMam / pm **or** H:MMam / pm. It is restricted to 7 characters in length.

## Setup/Installation Requirements
---
> This application requires the .NETCore SDK - [Find your version here](https://dotnet.microsoft.com/download/dotnet-core/2.2)

1. Create a BusinessLookup.Solution directory.
```
mkdir BusinessLookup.Solution
```
2. Navigate inside your new directory.
```
cd BusinessLookup.Solution
```
3. Clone this repository to your directory.
```
git clone https://github.com/mlstroud/BusinessLookup.git
```
4. Setup Database - Run the MySQL commands below:
```
CREATE DATABASE `matt_stroud`;

USE `matt_stroud`;
```
5. (OPTIONAL) Customize database settings
* If you want to use your own database settings, you may alter the appsettings.json file with the appropriate information:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=YOURDATABASEHERE;uid=YOURUSERNAMEHERE;pwd=YOURPASSWORDHERE;"
  }
}
```
>NOTE: Replace the database, username, and/or password with your own.
>If you choose to use your own database, update the value here and run the following MySQL commands:
```
DROP DATABASE `matt_stroud`;
CREATE DATABASE `YOUR_DATABASE_HERE`;
USE `YOUR_DATABASE_HERE`;
```
6. Apply database migrations.
```
dotnet ef database update
```
7. Run the application with the following command:
```
dotnet run
```

## Known Bugs
---
* V 2.0 GET route when queried by city has the potential to return incorect information. City is part of the address and query returns businesses where address contains the queried city name.
* Due to a bug with versioning on netcore 2.2, I was unable to get dynamic url version routing to work properly("/api/{v:apiVersion}/[controller]). Current workdaround was to hard code the version paths depending on API version.

## Stretch Goals
---
* Add user authentication.
* Add paginatated responses.
 
## Support and contact details
---
_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/BusinessLookup/issues) here on GitHub._

## Technologies Used
---
* C#
* .NET Core
* MVC
* RESTful Design
* Git
* WebAPI
* Swagger
* Versioning

### License
---
This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**