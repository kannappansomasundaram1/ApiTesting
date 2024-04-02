# ApiTesting
Explore different Tools to test APIs

## Http Files
Files with .http extensions that allows to send http requests 

Tests can be run from, 
* Visual Studio
* [Intellj HTTP Client](https://www.jetbrains.com/help/idea/http-client-in-product-code-editor.html)
* VSCode Extensions,
    * [Rest Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client), 
    * [Httpyac](https://marketplace.visualstudio.com/items?itemName=anweber.vscode-httpyac), 
    * 
* Command line using,
    * [Httpyac](https://httpyac.github.io/guide/installation_cli.html),
    * [Intellj HTTP Client CLI](https://blog.jetbrains.com/idea/2022/12/http-client-cli-run-requests-and-tests-on-ci/) 

## Httpyac CLI

I ran these tests with Httpyac CLI.
Steps to run the tests,

1. Install Httpyac CLI

```bash
npm install -g httpyac
```

2. Run the test using httpyac with the below command

```bash
httpyac Tests.http -all -o response -v
```
