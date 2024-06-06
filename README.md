# SimpleWebApp

This repository contains a simple ASP.NET Core MVC application along with an MSTest project for testing the web application using Selenium WebDriver.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)
- [Google Chrome](https://www.google.com/chrome/) (for Selenium tests)

## Setting Up the Development Environment

### Create and Run the ASP.NET Core MVC Project

1) Open a terminal and create a new ASP.NET Core MVC project:
   ### dotnet new mvc -n SimpleWebApp
   
2)Navigate to the project directory:
**cd SimpleWebApp**

3)Add the User model, HomeController, and Index view as per the instructions.

4)Run the application:
**dotnet run**

The application should now be running at **http://localhost:5000**

**Create and Set Up the Test Project**
1)Open a new terminal (or use the existing one) and create a new MSTest project:
**dotnet new mstest -n SimpleWebAppTests**

2)Navigate to the test project directory:
**cd SimpleWebAppTests**

3)Add Selenium WebDriver dependencies:
**dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver**

In the test project, create the WebAppTests.cs file with the provided test code.
