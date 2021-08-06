rm ./Enisn.Abp.1.0.10.nupkg
dotnet pack -o .
dotnet new -u Enisn.Abp
dotnet new -i ./Enisn.Abp.1.0.10.nupkg