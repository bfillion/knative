FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY event-display/event-display.csproj event-display/
RUN dotnet restore "event-display/event-display.csproj"
COPY . .
WORKDIR "/src/event-display"
RUN dotnet build "event-display.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "event-display.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "event-display.dll"]
