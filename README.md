# Backend Internship Challenge Spring 2022

This is a selection test for backend developers applying for internship at ViaEcole in the spring of 2022.

You should extend this website to fetch and search data from a database.

## Get up and running

1. Make sure you have [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) installed.
2. Clone and open the project backend-internship-challenge-spring2022/Web in your prefered IDE (VS Code, Visual Studio etc.).
3. Build and Run the project backend-internship-challenge-spring2022/Web.
4. You should see a web page with a list of two documents. 

## Assignment

The documents are not fetched from a database. You should create a database and fetch documents from that database and implement search. Document your toughts and 

### Fetch data from a database

1. Create a MS SQL Server Database
2. Run the script FillDatabase.sql to create tables and insert data
3. Rewrite the code in DatabaseAccess.cs to fetch the documents from the database. Use your prefered technique for fetching the data (ADO.NET, Entity Framework etc.).

### Implement search

On the web page there is a search textbox that posts the search string to a controller action if you hit Enter. 

* Search in FileName, FirstName and LastName.
* The search should be done on the server (not in the browser).
* Implement search as good as you can. Think about how the user would like the search to work.

### Document your assignment process

Document how your search works and how your thought process went during the assignment in a separate Markdown (.md) file.

## Submit your contribution

This description describes how you complete the assignment you got from Github Classroom.

* Commit your changes
* Push changes to the Github Classroom repository