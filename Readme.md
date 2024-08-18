
## dotnet ef commands:
	Install ef tools:
	dotnet tool install --global dotnet-ef
	dotnet add package Microsoft.EntityFrameworkCore.Design
	update-database

## Create Migration
	dotnet ef migrations add InitialMigration

## Some basic docker commands
	Pull image
	docker pull mcr.microsoft.com/mssql/server
	docker run -e "ACCEPT_EULA=" -e "SA_PASSWORD=sachin@123" -p 1400:1433 -d mcr.microsoft.com/mssql/server
	Get All Process
	docker ps -a

## Publish Docker Image
	Add container name as below
	<ContainerRepository>ConferenceAttendees.Api.DotNetPublish</ContainerRepository>

	Run Below Command To Generate Image
	dotnet publish --os linux --arch x64 /t:PublishContainer -c Release

	Run Image In Docker
	docker run -p 5000:8080 -p 5001:8081 --rm conferenceattendees-api-dotnetpublish

# Adding Seq for logging events
	docker pull datalust/seq
	docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest

# Angular Update
	npm uninstall -g @angular/cli
	npm install -g @angular/cli@latest
	docker build --pull --rm -f "Dockerfile" -t conferenceattendeesui:latest "."
	docker run -p 8080:80 conferenceattendeesui

# Setup Domain Name In Local
	C:\Windows\System32\drivers\etc
	Edit HOSTS File (add below line and save file)
	127.0.0.1 api.conferenceattendees.com
