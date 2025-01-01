# Étape 1 : Utiliser l'image de base de .NET SDK pour la compilation
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Définir le répertoire de travail pour la compilation
WORKDIR /src

# Copier le fichier .csproj dans le conteneur
COPY SQLi.Challenge/SQLi.Challenge.csproj SQLi.Challenge/

# Restaurer les dépendances
RUN dotnet restore "SQLi.Challenge/SQLi.Challenge.csproj"

# Copier le reste des fichiers du projet
COPY . .

# Publier l'application dans le répertoire /app
RUN dotnet publish "SQLi.Challenge/SQLi.Challenge.csproj" -c Release -o /app

# Étape 2 : Utiliser l'image de base runtime pour exécuter l'application
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Définir le répertoire de travail pour l'exécution
WORKDIR /app

# Copier les fichiers publiés depuis l'étape de build
COPY --from=build /app .

# Exposer le port utilisé par l'application
EXPOSE 80

# Démarrer l'application
ENTRYPOINT ["dotnet", "SQLi.Challenge.dll"]
