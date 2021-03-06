# Azure DevOps training material

[![Build Status](https://dev.azure.com/devprofr/open-source/_apis/build/status/training-supports/azure-pipeline-training-ci?branchName=main)](https://dev.azure.com/devprofr/open-source/_build/latest?definitionId=53&branchName=main)

Welcome to this training space!

Feel free to contribute, by sharing it, raising issues and creating Pull Requests!

## Introduction

You'll find here exercises to learn & practice [**Azure Pipelines**](https://azure.microsoft.com/en-us/services/devops/pipelines/), the pipeline engine of [Azure DevOps](https://azure.microsoft.com/en-us/services/devops/), ALM platform provided by Microsoft.

## Foreword

The knowledge you'll gather here will help you get better at CI tools in general. YAML definitions is the standard and if you are able to work with Azure Pipelines you won't be lost with other tools such as GitLab, GitHub actions, Travis, CircleCI and other recent tools.

## Requirements

### Azure DevOps account

* You'll need access to an Azure DevOps project with permissions to create pipelines

* You can create an organization for free at [**dev.azure.com**](https://dev.azure.com/)
  * All you need is a Microsoft account, which can be created from a non-Microsoft email adress (gmail or yahoo for example)
  * You may have to make a request for the free build minutes, see [Changes to Azure Pipelines free grants](https://docs.microsoft.com/en-us/azure/devops/release-notes/2021/sprint-184-update) (can take several days)

### Software

* You can create & edit pipelines directly in Azure DevOps web UI but it can be nice to also edit the yaml files locally on your workstation
  * An IDE such as [Visual Studio Code](https://code.visualstudio.com/) provides interesting extensions such as `EditorConfig for VS Code` by EditorConfig and `YAML` by Red Hat

* You can be more efficient with the right git client, such as [GitKraken](https://www.gitkraken.com/)

* For .NET code, it will be more convenient to work with [Visual Studio 2019](https://visualstudio.microsoft.com/) if you're on Windows (or [JetBrains Rider](https://www.jetbrains.com/rider/) if you're on Linux or Mac)

## Tips

* [**Microsoft documentation**](https://docs.microsoft.com/en-us/azure/devops/pipelines/?view=azure-devops) is well made, this is the first place to look at to know what do to.

* Use intensively the online editor assistant (when you create or edit a YAML build pipeline), it's the best way to get up to speed quickly.

* Take some time to get familiar with YAML, and remember indentation is key!

## Build pipelines (YAML)

## Build pipeline first steps - Beginner tour

* [1. Hello world](./docs/build-first-steps/01-helloworld.md)
* [2. Trigger](./docs/build-first-steps/02-trigger.md)
* [3. Variable](./docs/build-first-steps/03-variable.md)
* [4. .NET CI](./docs/build-first-steps/04-ci-dotnet.md)
* [5. Angular CI](./docs/build-first-steps/05-ci-angular.md)
* [6. Stage](./docs/build-first-steps/06-stage.md)
* [7. Parameter](./docs/build-first-steps/07-parameter.md)

## Build pipeline advanced steps - Intermediate tour

_TODO: work to be started in May/June 2021_
