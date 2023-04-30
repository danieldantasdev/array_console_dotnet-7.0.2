FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Array/Array.csproj", "Array/"]
RUN dotnet restore "Array/Array.csproj"
COPY . .
WORKDIR "/src/Array"
RUN dotnet build "Array.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Array.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Array.dll"]
