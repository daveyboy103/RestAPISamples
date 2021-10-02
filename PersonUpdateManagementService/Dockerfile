FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PersonUpdateManagementService/PersonUpdateManagementService.csproj", "PersonUpdateManagementService/"]
RUN dotnet restore "PersonUpdateManagementService/PersonUpdateManagementService.csproj"
COPY . .
WORKDIR "/src/PersonUpdateManagementService"
RUN dotnet build "PersonUpdateManagementService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonUpdateManagementService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersonUpdateManagementService.dll"]
