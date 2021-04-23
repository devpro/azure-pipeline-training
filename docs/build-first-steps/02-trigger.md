# Trigger pipeline (first steps)

We focus here on the conditions to execute a pipeline, aka triggers.

## Documentation

- [Specify events that trigger pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/triggers)
- [Build Azure Repos Git repositories > CI triggers](https://docs.microsoft.com/en-us/azure/devops/pipelines/repos/azure-repos-git)
- [Configure schedules for pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/scheduled-triggers)

## Exercise 02

### Success criteria

- [ ] Create a new file `.azure/pipelines/02-trigger.yml`
- [ ] The pipeline must contain only one task, entitled "Give time", that will display "Current date time is <datetime_utc>"
- [ ] Pipeline must run every hour
- [ ] Pipeline must run everytime there is a codechange ("commit") in `hotfix/urgent` and `release/*` branches
- [ ] A commit with only a change in `README.md` file shouldn't trigger a new run
- [ ] Create a new Azure Build pipeline in your folder and rename it to "02-trigger"

### Tips

- All tips from exercise 1 are relevant
- Once you have verified the schedule is ok, you can disable the pipeline ("Edit" link in the pipeline menu)
- After the pipeline has been validated, it's best to edit it and disable it so you don't have issue with build time limitation (free plan)

### Hints

- In Ubuntu, the date can be displayed with the `date -u +'%Y-%m-%d %H:%M:%S'` command
- Cron expression to have a process scheduled every start of hour: `0 */1 * * *`

## Next

Jump to next section: [3. Variable](./03-variable.md)
