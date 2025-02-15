﻿# AlphaEats Web App
A Full stack web development assessment. Most up to date code will be here:https://github.com/Shefuchow/AlphaEats A quick look:  

<img src="./img/docker.png" width="700">
<img src="./img/frontend.png" width="700">
<img src="./img/db2.png" width="700">


## Author
**Sefath Chowdhury** - [linkedin](https://www.linkedin.com/in/callmesefath/)

## Project Purpose
Display skill in:
 - Front End developement 
 - Backend development with data access layer using ORM
 - Beginner DevOps development 
 - SOLID Principles (single responsibility, loose coupling, dependancy injection, etc)
 - SPA design patterns in Angular (see component structure)
 - Ability to learn new technologies while working


## Built With
* [Angular](https://angularjs.org/) - The front-end framework used
* [Postgres](https://www.postgresql.org/) - Postgres DB database
* [.NET](https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet) - Backend development platform  
* [Docker](https://www.docker.com/) - Containerization solution

------
------
## Get Started
*I'm working on a Mac*

1. Here's the code tree:
```
.
├── AlphaEats.sln
├── AlphaEats.Api
├── AngularClient
├── docker_postgres_init.sql
└── docker-compose.yml
```

2. Please clone and cd into AlphaEats folder
```
git clone https://github.com/Shefuchow/AlphaEats
```
```
cd AlphaEats
```

3. Run `docker-compose up`

4. Grab a coffee, snack, maybe even catch a movie, this takes a while (~20 minutes? my personal mac is a dinosaur, need an M1 chip)

5. If you have Docker Desktop, here's what the containers should look like
![Containers](./img/docker.png)

6. Front end is on http://localhost:8080
![Frontend](./img/frontend.png)

7. Back end is on http://localhost:5000/swagger/index.html visualized and documented with SwaggerUi
![Frontend](./img/backend.png)
  
And you can current test the search api through swagger like this:
![swagger](./img/swagger.png)
  
I will update the frontend to take the post request and call the api. You can check on github here: https://github.com/Shefuchow/AlphaEats

8. PostgresAdmin is on http://localhost:16543 -> login in with  
`test@gmail.com`
`test123!`
![Login](./img/login.png)
Add New Server  
Name `root`
-> Connection Tab  
![addServer](./img/addserver.png)  

9. Go to root -> Schemas -> tables
Db are seeded with given CSVs (restaurant.csv and Cuisine.csv)
![Database1](./img/db1.png)
![Database2](./img/db2.png)

10. If you want, you can run this in visual studio as well, and click docker-compose as startup project and run that

11. To stop the containers after, asssuming these 4 were the only containers running, use `docker stop $(docker ps -q)` to stop all.

## Tools Used
 - Github (version control)
 - Visual Studio (code editor)
 - IKEA mattress (for power naps)
 - Nutribullet (for smoothies)