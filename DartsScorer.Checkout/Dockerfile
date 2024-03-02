FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DartsScorer.Checkout/DartsScorer.Checkout.csproj", "DartsScorer.Checkout/"]
RUN dotnet restore "DartsScorer.Checkout/DartsScorer.Checkout.csproj"
COPY . .
WORKDIR "/src/DartsScorer.Checkout"
RUN dotnet build "DartsScorer.Checkout.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DartsScorer.Checkout.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DartsScorer.Checkout.dll"]
