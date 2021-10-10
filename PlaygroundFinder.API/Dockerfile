#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PlaygroundFinder.API/PlaygroundFinder.API.csproj", "PlaygroundFinder.API/"]
RUN dotnet restore "PlaygroundFinder.API/PlaygroundFinder.API.csproj"
COPY . .
WORKDIR "/src/PlaygroundFinder.API"
RUN dotnet build "PlaygroundFinder.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlaygroundFinder.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlaygroundFinder.API.dll"]