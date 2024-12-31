# Utiliser l'image de base de .NET 6 SDK pour la phase de construction
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Définir le répertoire de travail
WORKDIR /app

# Copier les fichiers du projet dans le conteneur
COPY . .

# Restaurer les dépendances et construire le projet
RUN dotnet restore SQLi.Challenge/SQLi.Challenge.sln
RUN dotnet build SQLi.Challenge/SQLi.Challenge.sln -c Release -o /app/build

# Publier le projet pour la production
RUN dotnet publish SQLi.Challenge/SQLi.Challenge.sln -c Release -o /app/publish

# Utiliser l'image de base pour l'exécution (plus légère que le SDK)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

# Définir le répertoire de travail
WORKDIR /app

# Copier les fichiers publiés depuis la phase de construction
COPY --from=build /app/publish .

# Exposer le port que l'application écoute
EXPOSE 80

# Définir le point d'entrée de l'application
ENTRYPOINT ["dotnet", "SQLi.Challenge.dll"]
