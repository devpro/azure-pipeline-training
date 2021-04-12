# Stage pipeline (first steps)

We'll see the different levels of a pipeline definition.

## Documentation

- [Add stages, dependencies & conditions](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/stages)
- [Publish and download artifacts in Azure Pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/artifacts/pipeline-artifacts)

## Exercise 03

### Success criteria

- [ ] Create a new Azure Build pipeline named "03-stage" that will display "Hello from Windows" from a Windows agent, then "Hello from Mac" from a Mac agent
- [ ] Windows stage must create a non-empty file called `dummy.txt` that must be displayed by Mac stage
- [ ] Windows stage must contain exactly three tasks and Mac stage two tasks
- [ ] Pipeline definition must be in the file `.azure/pipelines/03-stage.yml`

### Tips

- All tips from exercise 1 are relevant

### Hints

- Complete pipeline definition hierarchy (Stage > Job > Step):

```yaml
stages:
- stage: A
  jobs:
  - job: A1
  - job: A2

- stage: B
  jobs:
  - job: B1
  - job: B2
```

## Next

Jump to next section: [4. .NET CI](./04-ci-dotnet.md)
