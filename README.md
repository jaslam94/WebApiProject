### Web API Project
The project uses ONION Architecture template based on [this](https://code-maze.com/onion-architecture-in-aspnetcore/) article.

It is a .NET 7 based Web API project.

- The project is configured to use an in-memory database.
- The functional requirements are implemented only which includes all of the endpoints mentioned in the requirements document with business rules.
- ONION layers such as Domain, Infrastructure and Persistence etc. are not added as separate assemblies, rather inside folders of the same project.
- Model validations, tests (unit and integration), API versioning and common response model pattern etc. are not implemented so far.
