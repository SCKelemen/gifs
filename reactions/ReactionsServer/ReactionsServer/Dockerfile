FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 24736
EXPOSE 44300

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ReactionsServer/ReactionsServer.csproj", "ReactionsServer/"]
RUN dotnet restore "ReactionsServer/ReactionsServer.csproj"
COPY . .
WORKDIR "/src/ReactionsServer"
RUN dotnet build "ReactionsServer.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ReactionsServer.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ReactionsServer.dll"]