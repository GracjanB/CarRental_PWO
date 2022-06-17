FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY . .
EXPOSE 8080
CMD ASPNETCORE_URLS=http://*:$PORT dotnet CarRental.API.dll