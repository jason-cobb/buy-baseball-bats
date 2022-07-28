# buy-baseball-bats
## ShopBaseballBats: a C# .Net MVC Solution
This repository contains a solution and all project files for a website named "Shop Fastpitch Softball Bats" that allows the user to see three manufacture brands of bats.  I started out calling it baseball bats generically but specified it to fastpitch softball bats since that is predominant in my household.

The home page will display three brands and a link to the page that lists all bat options available to select.  
The user will also be able to select the "Create Account" on the nav bar tab to input their information and then see it added to the customer information tab which shows it is added to the database as well.  I had aspirations to be able to add the bat selected to the shopping cart and tie the customer information together with it.  This will be the next steps.

## Technologies:
- Backend: C# 10 .NET 6
- ORM: EF 6
- Database: SQLite
- Frontend: Razor - HTML - JS - CSS

## Patterns
- MVC (Model, View, Controller)
- Code First Database Creation

## Getting Started
1. Clone 'https://github.com/jason-cobb/buy-baseball-bats.git'
2. Navigate to the 'ShopBaseballBats' solution folder
3. Run 'dotnet run'
4. View the bats, navigate to the bat models via the hyperlinks or the navbar to make a selection
5. Create an account! Go to the "Create Account" to input your information and create your account, upon input you will be directed to the customer page showing you are now in the database

## Requirements
- Create a class and populate with data: A class BaseballBats is in BaseballBats.cs and has a List of BatBrands. BatBrands contains too much information and in hindsight should have been smaller in scope.
- Create and call at least 3 functions or methods: 
  - BatBrandController line 23 function returns a list of bats to the index page
  - BatBrandController line 93 Task Edit function checks for null to throw exception or updates the database and redirects to index on submit
  - BaseballBatContext.cs line 46 starts a foreach loop to gather each bat brand, model and length to see to the database on ModelCreating line 67
 
 ## Features
 - Additional class that inherits from a parent: BaseballBatContext inherits from DbContext
 - Create a List and populate data: BaseballBatContext has a DBSet of Customers from Line 12 that will populate, retrieve and appear on the Create Account and Customer information pages
 - Unit Test is in CustomerTest.cs
 




