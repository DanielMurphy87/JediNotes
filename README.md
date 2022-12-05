
# JediNotes
 A Web Api for Jedis Notes utilizing Entity Framework using .Net 6
# Steps to Build and Run:
1. Open the solution in Visual Studio.
2. Edit the connection string in appsettings.json with you Database details
3. In the Package Manager Console type "Update-Database" to create the table and add the seed data, or else run the InitialDB.sql file in SSMS.
4. Run the solution, and test the endpoints using swagger. (localhost:PORT/swagger/index.html)