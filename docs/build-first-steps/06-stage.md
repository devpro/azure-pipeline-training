# Stage pipeline (first steps)

We'll see the different levels of a pipeline definition.

## Documentation

- [Add stages, dependencies & conditions](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/stages)
- [Publish and download artifacts in Azure Pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/artifacts/pipeline-artifacts)

## Exercise 06

### Success criteria

- [ ] Create a new file `.azure/pipelines/06-stage.yml`
- [ ] Windows stage must display "Hello from Windows" and create a non-empty file called `dummy.txt`
- [ ] Windows stage must contain exactly three tasks
- [ ] Mac stage must display "Hello from Mac" and read the content of the file `dummy.txt`
- [ ] Mac stage must contain exactly two tasks
- [ ] Create a new Azure Build pipeline in your folder and rename it to "06-stage"

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
