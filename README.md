# ABP-dotnet-template
 This is an example demo of dotnet template version of ABP Framework. Supports only database selection.
 
 It uses v4.4.0 app template of ABP.


## Installation

- Install templates from nuget:

```bash
dotnet new -i Enisn.Abp
```

- Create a project with CLI
  - EntityFrameworkCore

    ```bash
    dotnet new abp -D EfCore
    ```

  - MongoDb

    ```bash
    dotnet new abp -D MongoDb
    ```



- Create a project with IDE

  All installed templates will be visible at your IDE

  ![IDE preview](images/ide-preview.png)

  All parameters are selectable on IDE UI

  ![IDE Preview](images/ide-preview-2.png)
