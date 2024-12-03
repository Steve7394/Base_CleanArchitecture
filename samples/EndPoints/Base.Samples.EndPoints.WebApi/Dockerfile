# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["samples/EndPoints/Base.Samples.EndPoints.WebApi/Base.Samples.EndPoints.WebApi.csproj", "samples/EndPoints/Base.Samples.EndPoints.WebApi/"]
COPY ["src/EndPoints/Base.EndPoints.Web/Base.EndPoints.Web.csproj", "src/EndPoints/Base.EndPoints.Web/"]
COPY ["samples/EndPoints/Base.Sample.BackgroundWorker/Base.Sample.BackgroundWorker.csproj", "samples/EndPoints/Base.Sample.BackgroundWorker/"]
COPY ["src/EndPoints/Base.BackgroundWorker/Base.BackgroundWorker.csproj", "src/EndPoints/Base.BackgroundWorker/"]
COPY ["samples/Infra/Data/Base.Samples.Infrastructure/Base.Samples.Infrastructure.csproj", "samples/Infra/Data/Base.Samples.Infrastructure/"]
COPY ["src/Infra/Data/Base.Infrastructure.PostgreSQL/Base.Infrastructure.PostgreSQL.csproj", "src/Infra/Data/Base.Infrastructure.PostgreSQL/"]
COPY ["src/Infra/Data/Base.Infrastructure/Base.Infrastructure.csproj", "src/Infra/Data/Base.Infrastructure/"]
COPY ["src/Application/Base.Application/Base.Application.csproj", "src/Application/Base.Application/"]
COPY ["samples/Core/Base.Samples.Core.Contracts/Base.Samples.Core.Contracts.csproj", "samples/Core/Base.Samples.Core.Contracts/"]
COPY ["src/Core/Base.Core.Contracts/Base.Core.Contracts.csproj", "src/Core/Base.Core.Contracts/"]
COPY ["src/Core/Base.Core.Domains/Base.Core.Domains.csproj", "src/Core/Base.Core.Domains/"]
COPY ["samples/Core/Base.Samples.Core.Domain/Base.Samples.Core.Domain.csproj", "samples/Core/Base.Samples.Core.Domain/"]
COPY ["src/Utilities/Base.Utility/Base.Utility.csproj", "src/Utilities/Base.Utility/"]
COPY ["src/Application/Base.Application.RequestResponse/Base.Application.RequestResponse.csproj", "src/Application/Base.Application.RequestResponse/"]
COPY ["samples/Application/Base.Sample.Application/Base.Sample.Application.csproj", "samples/Application/Base.Sample.Application/"]
COPY ["src/Infra/Validators/Base.Infra.Validators.Abstractions/Base.Infra.Validators.Abstractions/Base.Infra.Validators.Abstractions.csproj", "src/Infra/Validators/Base.Infra.Validators.Abstractions/Base.Infra.Validators.Abstractions/"]
COPY ["samples/Application/Base.Sample.Application.RequestResponse/Base.Sample.Application.RequestResponse.csproj", "samples/Application/Base.Sample.Application.RequestResponse/"]
COPY ["src/Infra/Validators/Base.Infra.Validators/Base.Infra.Validators.csproj", "src/Infra/Validators/Base.Infra.Validators/"]
RUN dotnet restore "./samples/EndPoints/Base.Samples.EndPoints.WebApi/Base.Samples.EndPoints.WebApi.csproj"
COPY . .
WORKDIR "/src/samples/EndPoints/Base.Samples.EndPoints.WebApi"
RUN dotnet build "./Base.Samples.EndPoints.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Base.Samples.EndPoints.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Base.Samples.EndPoints.WebApi.dll"]