FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/D2.Docs.RazorClient/D2.Docs.RazorClient.csproj", "src/D2.Docs.RazorClient/"]
RUN dotnet restore "src/D2.Docs.RazorClient/D2.Docs.RazorClient.csproj"
COPY . .
WORKDIR "/src/src/D2.Docs.RazorClient"
RUN dotnet build "D2.Docs.RazorClient.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "D2.Docs.RazorClient.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "D2.Docs.RazorClient.dll"]
