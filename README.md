# generic_repository
A C# implementation of a generic repository pattern

This project is to have a go at creating a generic repository using EF Core with a Sqlite in-memory database. In this past I worked on a project that used an ORM (in that case nHibernate) with a Sqlite db for unit testing. I found it to be a very effictive way of working. I never looked under the hood of this setup and no longer have access to the project, so I thought I would try and do something similar but with EF Core instead.

Much of the work in this project was inspired by this medium post

https://medium.com/@marekzyla95/generic-repository-pattern-implemented-in-net-core-with-ef-core-c7e088c9c58

Although I had to implement the DbContext side myself as the author neglects to include that part or provide a complete project.
