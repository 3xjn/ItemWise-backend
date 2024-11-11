FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# First copy just the project file
COPY ["ItemWise/ItemWise.csproj", "ItemWise/"]
RUN dotnet restore "ItemWise/ItemWise.csproj"
# Then copy everything else
COPY . .