FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY ["WebAPI/WebAPI.csproj", "WebAPI/"]
RUN dotnet restore "WebAPI/WebAPI.csproj"

COPY . .
WORKDIR "/WebAPI"
RUN dotnet build "WebAPI.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "WebAPI.csproj" -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:5.0
ENV ASPNETCORE_URLS=http://+:7000
EXPOSE 7000
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI.dll"]