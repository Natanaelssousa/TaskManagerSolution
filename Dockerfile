FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["TaskManager/TaskManager.csproj", "TaskManager/"]
RUN dotnet restore "TaskManager/TaskManager.csproj"

COPY . .
WORKDIR "/src/TaskManager"
RUN dotnet publish "TaskManager.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TaskManager.dll"]