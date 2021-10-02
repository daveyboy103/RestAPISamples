FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SolidApiHarness/SolidApiHarness.csproj", "SolidApiHarness/"]
RUN dotnet restore "SolidApiHarness/SolidApiHarness.csproj"
COPY . .
WORKDIR "/src/SolidApiHarness"
RUN dotnet build "SolidApiHarness.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SolidApiHarness.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SolidApiHarness.dll"]
