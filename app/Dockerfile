FROM microsoft/aspnetcore-build:1.1.0-msbuild-rc3


ENV ASPNETCORE_ENVIRONMENT="Development"    

COPY . /app
WORKDIR /app

ENTRYPOINT sh /app/start.sh