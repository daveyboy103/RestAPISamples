FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PersonDeletionManagementService/PersonDeletionManagementService.csproj", "PersonDeletionManagementService/"]
RUN dotnet restore "PersonDeletionManagementService/PersonDeletionManagementService.csproj"
COPY . .
WORKDIR "/src/PersonDeletionManagementService"
RUN dotnet build "PersonDeletionManagementService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonDeletionManagementService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersonDeletionManagementService.dll"]
