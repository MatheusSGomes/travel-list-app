# Travel List Api


Para subir uma instância do PostgreSQL via docker:
```
docker compose up -d
```

Para criar uma nova migration:
```
dotnet ef migrations add Travels -p ./TravelListApp.Persistence/TravelListApp.Persistence.csproj -s ./TravelListApp.Api/TravelListApp.Api.csproj
```

Para cadastrar no banco a migration criada:
```
dotnet ef database update -p ./TravelListApp.Persistence/TravelListApp.Persistence.csproj -s ./TravelListApp.Api/TravelListApp.Api.csproj
```
