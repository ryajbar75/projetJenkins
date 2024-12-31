FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copier le fichier .csproj
COPY SQLi.Challenge.csproj SQLi.Challenge/

RUN dotnet restore "SQLi.Challenge/SQLi.Challenge.csproj"

# Copier tout le reste
COPY . .

# Construire le projet
RUN dotnet build "SQLi.Challenge/SQLi.Challenge.csproj" -c Release -o /app/build

# Publier le projet
RUN dotnet publish "SQLi.Challenge/SQLi.Challenge.csproj" -c Release -o /app/publish

# Utiliser l'image de base .NET pour exécuter l'application
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SQLi.Challenge.dll"]
