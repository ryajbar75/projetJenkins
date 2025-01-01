# Utilisez l'image de base .NET
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Ajoutez l'image SDK pour la compilation
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copier le fichier .csproj (ajustez le chemin en fonction de votre structure)
COPY SQLi.Challenge/SQLi.Challenge/SQLi.Challenge.csproj SQLi.Challenge/

# Restaurer les dépendances
RUN dotnet restore "SQLi.Challenge/SQLi.Challenge.csproj"

# Copier tous les fichiers source
COPY . .

# Publier l'application
WORKDIR /src/SQLi.Challenge
RUN dotnet publish "SQLi.Challenge.csproj" -c Release -o /app/publish

# Finaliser l'image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SQLi.Challenge.dll"]
