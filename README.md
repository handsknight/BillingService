# BillingService
IP location Lookup Billing

//to perform migrations steps
1. open the project in visual studio
1. In appsetting: change the name of the defaultconnection string server name to your server name   where your database resides
3. Open Package Manager and change default project to Billing.Infrastructure run 'update-database'


//To run the project:
1. Open the project in your local system
2. press F5 or Ctrl+F5


//To run the Test cases : Note: there is a Unit Test project called Billing.Test.

//To run Test cases: 
1. open the Billing.Test Project
2. Select Tools from menu bae and select Run All Test

//Database 
1. Sql Server is used
2. The migration will create all necessay databse objects. Just run update-database either in your command prompt or Nuget Package console in visual studio