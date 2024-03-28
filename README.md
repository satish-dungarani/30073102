# Procom.Utilities.OBSMigrationTool

## Overview
The Procom.Utilities.OBSMigrationTool is a console application designed to facilitate the migration of legacy data stored in Cosmos DB. This tool is particularly useful for updating documents within the Cosmos DB, performing patch operations as necessary.

## Features
- Patch operations for updating documents in Cosmos DB.
- Configuration flexibility through the `appsettings.json` file.
- Ability to specify particular document IDs for updating or update all records of documents.

## Configuration
Ensure that the `appsettings.json` file is correctly configured before running the application. This file contains the necessary settings for connecting to your Cosmos DB instance and specifying the documents and scenarios to be updated.

### `appsettings.json` Structure
```json
{
  "DatabaseSetting": {
    "EndpointUrl": "<Your_CosmosDB_EndpointUrl>",
    "AuthKey": "<Your_CosmosDB_AuthKey>",
    "Database": "<Your_Database_Name>",
    "Container": "<Your_Container_Name>"
  },

  "DocumentSetting": {
    "EnvironmentName": "<Your_Environment_Name>",
    "DocumentIds": [
      // Specify Document IDs to update, or leave empty to update all
    ],
    "Scenarios": [
      // Specify Scenarios to apply updates
    ]
  }
}
```

## Database Setting
- **EndpointUrl:** The URL endpoint of your Cosmos DB instance.
- **AuthKey:** The authentication key for accessing your Cosmos DB.
- **Database:** The name of the database within your Cosmos DB instance.
- **Container:** The name of the container within your database.

## Document Setting
- **EnvironmentName:** The environment name for reference.
- **DocumentIds:** An array of document IDs to update. Leave empty to update all documents.
- **Scenarios:** An array of scenarios to apply updates.

## Usage
To use the Procom.Utilities.OBSMigrationTool:
1. Configure the `appsettings.json` file with your Cosmos DB settings and desired update criteria.
2. Build the application.
3. Run the executable or debug the application from your development environment.

Upon execution, the tool will connect to your Cosmos DB instance and perform the specified updates according to the provided configurations.

## Note
- Ensure that you have appropriate permissions and connectivity to your Cosmos DB instance before running the tool.
- Always review and verify the `appsettings.json` configuration to avoid unintended data modifications.


