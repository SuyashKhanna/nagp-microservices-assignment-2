FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["User Service.API/User Service.csproj", "User Service.API/"]
RUN dotnet restore "User Service.API/User Service.csproj"
COPY . .
WORKDIR "/src/User Service.API"
RUN dotnet build "User Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "User Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "User Service.dll"]