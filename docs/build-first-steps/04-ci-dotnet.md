# .NET 5 continuous integration pipeline (first steps)

We'll now a concrete example of building a Continuous Integration pipeline from an existing .NET codebase (from `samples` folder).

## Documentation

- [Build, test, and deploy .NET Core apps](https://docs.microsoft.com/en-us/azure/devops/pipelines/ecosystems/dotnet-core)

## Exercise 04

### Success criteria

- [ ] Create a new Azure Build pipeline named "04-dotnet5-ci"
- [ ] Pipeline definition must be in the file `.azure/pipelines/04-dotnet5-ci.yml`
- [ ] Pipeline should ensure .NET SDK 5.0.x is installed
- [ ] Pipeline should validate .NET code in `samples/dotnet5`: restore NuGet packages, build the solution & run the tests
- [ ] Every task must be done in distinct steps
- [ ] No command line is authorized in this exercise, only use available tasks
- [ ] All specific values must be defined as variables, no string duplication, no hard coded values in tasks

### Tips

- All tips from exercise 1 are relevant

### Hints

- Create tasks from the online editor assistant
- Command line equivalent:

```bash
# go to sample directory
cd samples/dotnet5

# should display 5.0.XXX
dotnet version

# restore the NuGet packages used by the projects of the solution
dotnet restore Dotnet5Sample.sln

# build the projects of the solution
dotnet build Dotnet5Sample.sln --no-restore -c Debug

# run tests
dotnet tests test/**/*Tests.csproj -c Debug --no-restore --no-build
```

## Next

Jump to next section: [5. Angular CI](./05-ci-angular.md)
