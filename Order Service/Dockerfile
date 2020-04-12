FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Order Service.API/Order Service.csproj", "Order Service.API/"]
RUN dotnet restore "Order Service.API/Order Service.csproj"
COPY . .
WORKDIR "/src/Order Service.API"
RUN dotnet build "Order Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Order Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Order Service.dll"]