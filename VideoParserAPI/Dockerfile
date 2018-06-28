FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY VideoParserAPI/VideoParserAPI.csproj VideoParserAPI/
RUN dotnet restore VideoParserAPI/VideoParserAPI.csproj
COPY . .
WORKDIR /src/VideoParserAPI
RUN dotnet build VideoParserAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish VideoParserAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VideoParserAPI.dll"]
