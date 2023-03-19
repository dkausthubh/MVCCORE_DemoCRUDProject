# MVCCORE_DemoCRUDProject

This a sample .NET CORE MVC Project with simple CRUD Operations using Enity Framework Core 7.0, html, css, bootstrap

startup: CoreMVCDEmo sln

Here I have incorporated N-Layer Architecture where model & data access layer is separate from .net core project in class liabrary Project.
N Layers refer to a logical separation of components, such as having distinct namespaces and classes for the Database Access Layer (DAL), Business Logic Layer (BLL) and User Interface Layer (UIL).
Layered architecture focuses on the grouping of related functionality within an application into distinct layers that are stacked vertically on top of each other.

The Repository pattern is used for abstracting how data is persisted or retrieved from a database. The idea behind the Repository pattern is to decouple the data access layer from the business access layer of the application so that the operations (such as adding, updating, deleting, and selecting items from the collection) is done through straightforward methods without dealing with database concerns such as connections, commands etc.

here Repository Pattern consist of  GENERIC CLASS > MODEL CLASS > UNIT OF WORK 
IREPOSITORY has ALL COMMON FUNCTION : all the basic operations related to an entity are declared in the interface like GET ALL IEnumerable , GET BY ID T GetT(Expression<Func<T, bool>> predicate), ADD, REMOVE , REMOVERange
model repository for update function.
classes : Categoryrepository  has datacontext object to get data and implement category repository .
