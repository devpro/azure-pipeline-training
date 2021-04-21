# Angular continuous integration pipeline (first steps)

## Documentation

- [Build, test and deploy JavaScript and Node.js apps](https://docs.microsoft.com/en-us/azure/devops/pipelines/ecosystems/javascript)

## Exercise 02

### Success criteria

- [ ] Create a new Azure Build pipeline named "05-angular-ci"
- [ ] Pipeline definition must be in the file `.azure/pipelines/05-angular-ci.yml`
- [ ] Pipeline should ensure NPM is installed
- [ ] Pipeline should validate JavaScript/TypeScript code in `samples/angular`: restore NPM packages, lint & run the tests
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
cd samples/angular

# install globally Angular CLI
npm install -g @angular/cli

# restore NPM NuGet packages
npm install

# lint code
npm run lint

# run tests
npm run test-once
```

## Next

Jump to next section: [6. Stage](./06-stage.md)
