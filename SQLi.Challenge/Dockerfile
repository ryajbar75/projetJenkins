# Étape 1 : Construire l'application
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SQLi.Challenge/SQLi.Challenge.csproj", "SQLi.Challenge/"]
RUN dotnet restore "SQLi.Challenge/SQLi.Challenge.csproj"
COPY . .
WORKDIR "/src/SQLi.Challenge"
RUN dotnet build "SQLi.Challenge.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SQLi.Challenge.csproj" -c Release -o /app/publish

# Étape 2 : Exécuter l'application
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SQLi.Challenge.dll"]
