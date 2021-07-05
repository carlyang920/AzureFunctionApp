## Please create local.settings.json for your local debugging
## Or you can put the example as below into your file.

`Note: If you have no local.settings.json, you will not be able to run this project.`

```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "[input your azure storage connection]",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet"
  }
}
```