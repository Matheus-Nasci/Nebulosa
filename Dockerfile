FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base

WORKDIR /app

EXPOSE 8080

RUN dotnet publish "./Nebulosa.csproj"
