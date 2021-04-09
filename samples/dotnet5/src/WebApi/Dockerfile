FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY . .
WORKDIR "/src/WebApi"
RUN dotnet restore "WebApi.csproj"
RUN dotnet build "WebApi.csproj" -c Release --no-restore -o /app/build

FROM build AS publish
RUN dotnet publish "WebApi.csproj" -c Release --no-restore  --no-build -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dotnet5Sample.WebApi.dll"]
