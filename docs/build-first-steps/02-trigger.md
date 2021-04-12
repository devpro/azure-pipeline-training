# Triger pipeline (first steps)

We focus here on the conditions to execute a pipeline, aka triggers.

## Documentation

- [Specify events that trigger pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/triggers)
- [Build Azure Repos Git repositories > CI triggers](https://docs.microsoft.com/en-us/azure/devops/pipelines/repos/azure-repos-git)
- [Configure schedules for pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/scheduled-triggers)

## Exercise 02

### Success criteria

- [ ] Create a new Azure Build pipeline named "02-trigger" that will display "Current date time is <datetime_utc>"
- [ ] The pipeline must contain only one task, entitled "Give time"
- [ ] Pipeline definition must be in the file `.azure/pipelines/02-trigger.yml`
- [ ] Pipeline must run every hour and everytime there is a code change in the `hotfix/urgent` and `release/*` branches
- [ ] Pipeline shouldn't be triggered if there hasn't been a code change in the branch or if it's only a code change on `README.md` file

### Tips

- All tips from exercise 1 are relevant

### Hints

- In Ubuntu, the date can be displayed with the `date -u +'%Y-%m-%d %H:%M:%S'` command
- Cron expression to have a process scheduled every start of hour: `0 */1 * * *`

## Next

Jump to next section: [3. Stage](./03-stage.md)
