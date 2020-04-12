FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Aggregator Service.API/Aggregator Service.csproj", "Aggregator Service.API/"]
RUN dotnet restore "Aggregator Service.API/Aggregator Service.csproj"
COPY . .
WORKDIR "/src/Aggregator Service.API"
RUN dotnet build "Aggregator Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aggregator Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Aggregator Service.dll"]