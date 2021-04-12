# Stage pipeline (first steps)

We'll see the different levels of a pipeline definition.

## Documentation

- [Add stages, dependencies & conditions](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/stages)
- [Publish and download artifacts in Azure Pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/artifacts/pipeline-artifacts)

## Exercise 03

### Success criteria

- [ ] Create a new Azure Build pipeline named "06-stage" that will display "Hello from Windows" from a Windows agent, then "Hello from Mac" from a Mac agent
- [ ] Pipeline definition must be in the file `.azure/pipelines/06-stage.yml`
- [ ] Windows stage must display "Hello from Windows" and create a non-empty file called `dummy.txt`
- [ ] Windows stage must contain exactly three tasks
- [ ] Mac stage must display "Hello from Mac" and read the content of the file `dummy.txt`
- [ ] Mac stage must contain exactly two tasks

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

Jump to next section: [7. Parameter](./07-parameter.md)
