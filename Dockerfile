# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
EXPOSE 80
EXPOSE 443

#Copy csproj and restore as distinct layers
COPY *.sln ./
COPY DAL/*.csproj ./DAL/
COPY BAL/*.csproj ./BAL/
COPY WebAPI/*.csproj ./WebAPI/
RUN dotnet restore

#Copy everything else and build
COPY DAL/. ./DAL/
COPY BAL/. ./BAL/
COPY WebAPI/. ./WebAPI/
#Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=build-env /app/out .
CMD dotnet WebAPI.dll && fg