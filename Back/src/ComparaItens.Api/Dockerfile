#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ComparaItens.Api/ComparaItens.Api.csproj", "ComparaItens.Api/"]
COPY ["ComparaItens.Domain/ComparaItens.Domain.csproj", "ComparaItens.Domain/"]
COPY ["ComparaItens.Infra/ComparaItens.Infra.csproj", "ComparaItens.Infra/"]
RUN dotnet restore "ComparaItens.Api/ComparaItens.Api.csproj"
COPY . .
WORKDIR "/src/ComparaItens.Api"
RUN dotnet build "ComparaItens.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ComparaItens.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ComparaItens.Api.dll"]

RUN useradd -m myappuser
USER myappuser

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet ComparaItens.Api.dll