# 1st base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# make folder app 
WORKDIR /app

# add file of dependencies (.csproj) in app  
COPY *.csproj .
# retrieve dependencies before building
RUN dotnet restore

# Generate development certificate
RUN dotnet dev-certs https

# copy and publish all application files
COPY . . 

EXPOSE 5014 7067

CMD ["dotnet", "run","--urls", "http://0.0.0.0:5014;https://0.0.0.0:7067"]
# ENTRYPOINT ["dotnet", "run","--urls", "http://0.0.0.0:5014;https://0.0.0.0:7067"]
