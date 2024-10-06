
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
	docker run -p 8084:8084 conferenceattendeesui

# Setup Domain Name In Local
	C:\Windows\System32\drivers\etc
	Edit HOSTS File (add below line and save file)
	127.0.0.1 api.conferenceattendees.com

# Migration script
	dotnet ef migrations script --idempotent

# Run Docker With Multiple Docker Files
	docker-compose -f docker-compose.yml -f docker-compose.stage.yml up -d

# K8S command
	-- add name space in k8s
	kubectl apply -f .\namespace.yml
	-- add mssql server in k8s server
	kubectl apply -f .\mssql-deployment.yaml
	-- view service
	kubectl get all
	kubectl get all --namespace=cloud-native-dev
	-- add seq service in k8s server
	kubectl apply -f .\seq-deployment.yaml
	-- add seq service in k8s server (**change the folder location of yaml files)
	kubectl apply -f .\k8s\api-deployment.yaml

# Push Conferenceattendess-api project in Docker Hub
	-- let build a image the project
	docker build -t conferenceattendees-api -f .\ConferenceAttendees.Api\Dockerfile .
	-- let commit the image in local
	docker image tag conferenceattendees-api:latest pysachindocker/conferenceattendees-api:latest
	-- let push the image to docker hub
	docker push pysachindocker/conferenceattendees-api:latest
	-- k8s api
	kubectl apply -f .\k8s\api-deployment.yaml

# Push Conferenceattendess-ui project in Docker Hub
	-- let build a image the project
	docker build -t conferenceattendees-ui -f .\Dockerfile .                         
	-- let commit the image in local
	docker image tag conferenceattendees-ui:latest pysachindocker/conferenceattendees-ui:latest
	-- let push the image to docker hub
	docker push pysachindocker/conferenceattendees-api:latest

# Create Volume for mssql
	-- create the persistence-volumes.yml
	kubectl apply -f .\k8s\persistence-volumes.yml
	-- command to check storage class
	kubectl get storageclass
	kubectl get pvc -n=cloud-native-dev
	-- command to get details of running app
	kubectl describe pod -l app=mssql -n=cloud-native-dev

# Delete PODs
	-- command to delete PODS by name
	kubectl get all --namespace=cloud-native-dev
	kubectl delete pod pod/mssql-5b4679478b-6cwkf -n=cloud-native-dev

	-- command to delete all pods in namespace
	kubectl delete all -n=cloud-native-dev --all

	-- create all PODs again
	kubectl apply -f .\k8s\.
  
  
