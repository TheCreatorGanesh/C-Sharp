FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["E.D.A.Ubiquitous/E.D.A.Ubiquitous.csproj", "E.D.A.Ubiquitous/"]
RUN dotnet restore "E.D.A.Ubiquitous/E.D.A.Ubiquitous.csproj"
COPY . .
WORKDIR "/src/E.D.A.Ubiquitous"
RUN dotnet build "./E.D.A.Ubiquitous.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./E.D.A.Ubiquitous.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "E.D.A.Ubiquitous.dll"]
