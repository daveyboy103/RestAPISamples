FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PersonCreationManagementService/PersonCreationManagementService.csproj", "PersonCreationManagementService/"]
RUN dotnet restore "PersonCreationManagementService/PersonCreationManagementService.csproj"
COPY . .
WORKDIR "/src/PersonCreationManagementService"
RUN dotnet build "PersonCreationManagementService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonCreationManagementService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersonCreationManagementService.dll"]
