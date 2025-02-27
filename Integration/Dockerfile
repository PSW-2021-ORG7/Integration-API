#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
RUN groupadd -r user -g 443 && \
    useradd -u 101 -r -g user newuser
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
COPY ["init.sql", "app/scripts/"]
WORKDIR /src
COPY ["Integration API/Integration API.csproj", "Integration API/"]
RUN dotnet restore "Integration API/Integration API.csproj"

WORKDIR "/src/Integration API"
ARG src="/Integration API"
COPY ${src} .
RUN dotnet build "Integration API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Integration API.csproj" -c Release -o /app/publish

FROM base AS final
USER newuser
WORKDIR /app
COPY --from=publish /app .
WORKDIR /app/publish
VOLUME /app/scripts
ENTRYPOINT ["dotnet", "Integration API.dll"]