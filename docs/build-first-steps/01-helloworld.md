# Hello world pipeline - First steps

We'll build our first pipeline to display a custom "Hello World" message.

## Exercise 01

### Success criteria

- [ ] Create a new Azure Build pipeline named "01-helloworld" that will display "Hello from <machine_name>"
- [ ] The pipeline must contain only one task, entitled "Say hello"
- [ ] Pipeline definition must be in the file `.azure/pipelines/01-helloworld.yml`

### Tips

- You are free to use any type of Microsoft hosted agent
- Create a new branch on this repository to make your change
- If you are on a shared project with other people, create a folder only for you (with your first name for example)
- You can either use the default pipeline provided by Microsoft or do it from scratch

### Hints

- In Ubuntu, the machine name can be retrieved from the `hostname` command