# MVCCORE_DemoCRUDProject

This a sample .NET CORE MVC Project with simple CRUD Operations using Enity Framework Core 7.0, html, css, bootstrap

startup: CoreMVCDEmo sln

Here I have incorporating N-Tier Architecture where model & data access layer is separate from .net core project in class liabrary Project.
Repository Pattern consisting GENERIC CLASS > MODEL CLASS > UNIT OF WORK 
IREPOSITORY has ALL COMMON FUNCTION : GET ALL IEnumerable , GET BY ID T GetT(Expression<Func<T, bool>> predicate), ADD, REMOVE , REMOVERange
model repository for update function.
classes : Categoryrepository  has datacontext object to get data and implement category repository .
