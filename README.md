# Son Of Cod Seafood

#### _Simple app for proacticing user authentication and user roles._

#### By _Lina Shadrach_

## Description
_This app allows an admin to manage a who subscribes to a newsletter and who has access to administrative areas of the site. A user is able to login, subscribe to, and unsubscribe from the newsletter._

## Development framework
This project was generated with [.NET Core](https://www.microsoft.com/net/core#windowsvs2015).

## Database
This project's database is managed using [SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

To regenerate this database shema, establish a connection to your local server through SSMS, build the project, then run the commands:

* > dotnet ef migrations Initial 
* > dotnet ef database update

in the CLI while located in src/SonOfCodSeafood folder of this project.

## Installation

* `git clone <https://github.com/LinaShadrach/SonOfCodSeafood>`

## Known Bugs

_As of now, anyone can add themself as an administrator._

## Support and contact details
_Please contact author through GitHub at username: LinaShadrach_

## Technologies and Resources used
_Bootstrap, CSS, GitHub, HTML, C#, .NET, SSMS, Visual Studio 2015_

### License
_MIT_
 Copyright(c) 2016 ***Lina Shadrach***