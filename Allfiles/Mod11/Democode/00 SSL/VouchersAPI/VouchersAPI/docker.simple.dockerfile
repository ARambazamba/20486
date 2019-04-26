FROM microsoft/dotnet:2.2-sdk
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy and build everything else
COPY . ./
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/Vouchers.dll"]
EXPOSE 8080/tcp
ENV ASPNETCORE_URLS https://*:5000

# Pull & Run SQL Linux
# docker pull microsoft/mssql-server-linux:latest
# docker run -d --name sqllinux -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=TiTp4SQL@dmin' microsoft/mssql-server-linux

# Build Image
# docker build --rm -f "docker.simple.dockerfile" -t vouchersapi:latest .

# Run Image including SQL
# docker run -d --rm -it -p 8080:5000 --link sqllinux:sqllinux vouchersapi:latest