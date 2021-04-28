# Hello world pipeline - First steps

We'll build our first pipeline to display a custom "Hello World" message.

## Documentation

- [Key concepts for new Azure Pipelines users](https://docs.microsoft.com/en-us/azure/devops/pipelines/get-started/key-pipelines-concepts)
- [Run cross-platform scripts](https://docs.microsoft.com/en-us/azure/devops/pipelines/scripts/cross-platform-scripting)

## Exercise 01

### Success criteria

- [ ] Create a new file `.azure/pipelines/01-helloworld.yml`
- [ ] The pipeline must contain only one task, entitled "Say hello", that will display "Hello from <machine_name>"
- [ ] Create a new Azure Build pipeline in your folder and rename it to "01-helloworld"

### Tips

- Work on a branch in git, create it if it doesn't exist
- Isolate your pipelines in a dedicated folder (with your first name for example)
- Use any type of Microsoft hosted agent
- In the pipeline creation wizard, use a template or create it from scratch
- Always add `trigger` at the top of the file to not use the default behavior, explicitly define the wished behavior (just put `trigger: none` to prevent a commit on your branch to prevent a new run)

### Hints

- In Ubuntu, the machine name can be displayed with the `hostname` command

## Next

Jump to next section: [2. Trigger](./02-trigger.md)
