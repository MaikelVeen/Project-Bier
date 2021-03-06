Beer Webshop
============

This is the repository for Project C - Webshop at the Rotterdam University of Applied Sciences. 

The system is a webshop with functional admin dashboard interface. Users can order, search, save and select products.

The admin can edit and delete user and product data. He or she can also view statistics about user behaviour and sales.

(This README is currently a stub and will be expanded later.)

## Running the project

Make sure you have the .NET Core SDK and NodeJS installed. Before trying to run the project always run a

'dotnet restore'

in the main folder of the project. This command wil get all the missing packages of the backend. When done change the terminal folder to ClientApp and run 

'npm install'

This will install all packages for the frontend, which are defined in package.json. There will be a prompt to install semantic UI. This is needed to have custom themes for Semantic UI. Enter the following in the prompt:

![Prompt](https://jsramblings.com/images/semantic-ui-theme/step5.PNG)

Make sure you install semantic in the correct folder: src/semantic !

## Updating the generated CSS
When you have updated the bier theme of semantic you should update the generated minified CSS. You can do this by running this command in the ClientApp folder:
'npm run build-semantic'

##  Tech Stack
* React + Semantic UI
* ASP .NET Core
* EF Core
* SQLite

## Documentation and Tutorials
Here follows a list meant for team members to quickly access
resources and tutorials

### Backend
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.1)
* [Entity Framework Core](https://docs.microsoft.com/nl-nl/ef/core/)

### Database
We use SQLite database for now. This is embedded into the backend and does not need a seperate process.

### Frontend
* [React Router Tutorial](https://www.youtube.com/watch?v=91F8reC8kvo)
* [React Basics Playlist](https://www.youtube.com/watch?v=JPT3bFIwJYA&list=PL55RiY5tL51oyA8euSROLjMFZbXaV7skS)
* [ReactJS Tutorial (2h)](https://www.youtube.com/watch?v=pgAvVxowaYU)
* [E6 JS Beginner Tutorial(1h)](https://www.youtube.com/watch?v=IEf1KAcK6A8)
* [Curated list of awesome react resources](https://github.com/enaqx/awesome-react)



# Contributors
* [Maikel Veen](https://github.com/MaikelVeen)
* [Kenny Jiang](https://github.com/Aznkenny93)
* [Tanja Nguyen]()
* [Wessel Schuurman](https://github.com/PietPizza)
* [Romano Badal](https://github.com/romanobadal)