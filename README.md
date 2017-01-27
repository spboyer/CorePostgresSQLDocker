# CorePostgresSQLDocker

MSBUILD version of https://github.com/danwahlin/AspNetCorePostgreSQLDockerApp 

```
npm install
```

then run docker commands to build/download image(s)

```
docker-compose build
```

run application

```
docker-compose up
```

* Navigate to http://localhost:5000/api/customerservice/customers
* Change a file to see the dotnet-watch tool stop re-compile and restart the application within the container.
    * i.e. Line 32 of CustomerServiceController.cs 

    ```csharp
    customers.Add(new Customer(){Id=999, FirstName="Shayne", LastName="Boyer", Email="myname@email.com"});
    ```

* Refresh the browser