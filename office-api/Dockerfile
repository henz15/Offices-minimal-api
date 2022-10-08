FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["office-api/office-api.csproj", "office-api/"]
RUN dotnet restore "office-api/office-api.csproj"
COPY . .
WORKDIR "/src/office-api"
RUN dotnet build "office-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "office-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "office-api.dll"]
