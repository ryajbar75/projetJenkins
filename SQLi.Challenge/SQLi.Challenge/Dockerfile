# Utiliser l'image de base de .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Définir le répertoire de travail
WORKDIR /src

# Copier le fichier .csproj et restaurer les dépendances
COPY SQLi.Challenge/SQLi.Challenge.csproj SQLi.Challenge/
RUN dotnet restore "SQLi.Challenge/SQLi.Challenge.csproj"

# Copier le reste des fichiers du projet
COPY . .

# Publier l'application
RUN dotnet publish "SQLi.Challenge/SQLi.Challenge.csproj" -c Release -o /app

# Utiliser l'image de base runtime pour l'exécution
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app .

# Exposer le port de l'application
EXPOSE 80

# Démarrer l'application
ENTRYPOINT ["dotnet", "SQLi.Challenge.dll"]
