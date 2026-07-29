FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY OrbitBoard.Api.sln ./
COPY OrbitBoard.Api/OrbitBoard.Api.csproj OrbitBoard.Api/
RUN dotnet restore OrbitBoard.Api.sln

COPY OrbitBoard.Api/ OrbitBoard.Api/
RUN dotnet publish OrbitBoard.Api/OrbitBoard.Api.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:5200
EXPOSE 5200

RUN apt-get update \
    && apt-get install -y --no-install-recommends curl \
    && rm -rf /var/lib/apt/lists/*

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "OrbitBoard.Api.dll"]
