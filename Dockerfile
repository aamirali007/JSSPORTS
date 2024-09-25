# Use the official Microsoft image for building the project
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the .csproj file and restore dependencies (via nuget)
COPY *.csproj ./
RUN dotnet restore

# Copy the entire project
COPY . ./

# Build the project
RUN dotnet publish -c Release -o /out

# Use the official runtime image for .NET Core 6.0
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the output from the build stage to the runtime stage
COPY --from=build /out .

# Expose the port your application is running on (default is 80)
EXPOSE 80

# Start the Web API
ENTRYPOINT ["dotnet", "SportsOrderApp.dll"]
