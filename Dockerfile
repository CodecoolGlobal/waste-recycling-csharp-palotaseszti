# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy the solution and project files
COPY WasteRecycling.sln ./
COPY src/Codecool.WasteRecycling/Codecool.WasteRecycling.csproj src/Codecool.WasteRecycling/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the code, including ruleset
COPY src/Codecool.WasteRecycling/ ./src/Codecool.WasteRecycling/
COPY src/Codecool.ruleset ./src/Codecool.ruleset

# Publish the application
RUN dotnet publish src/Codecool.WasteRecycling/Codecool.WasteRecycling.csproj -c Release -o /app/publish

# Use the official .NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "Codecool.WasteRecycling.dll"]
