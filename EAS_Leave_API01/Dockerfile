#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["EAS_Leave_API01/EAS_Leave_API01.csproj", "EAS_Leave_API01/"]
RUN dotnet restore "EAS_Leave_API01/EAS_Leave_API01.csproj"
COPY . .
WORKDIR "/src/EAS_Leave_API01"
RUN dotnet build "EAS_Leave_API01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EAS_Leave_API01.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EAS_Leave_API01.dll"]