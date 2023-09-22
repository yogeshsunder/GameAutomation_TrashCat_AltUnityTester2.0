# GameAutomation_TrashCat_AltUnityTester2.0
This is the framework to automate a 3D game using AltUnityTester

Command for Setup of AltTester
Check Dotnet Version
- dotnet --version 

Create new folder 
- mkdir trashcat-tests
- cd trashcat-tests

Add NUnit for dotnet
- dotnet new nunit

Add package
- dotnet add package AltTester-Driver --version 2.0.1
- ls -la

Restore Project
- dotnet test

After this 
- open VS code
- open created folder
- On test Explorer, Click on Open setting
- Write this code on setting.json
{
    "dotnet-test-explorer.testProjectPath": "*.csproj"
}
- Run the test.

Open the testing app.
Check the server name on application - user system IP address(To check IP of your system ifconfig |grep 192.168).

Open the AltTester Desktop
- Click on inspect App.

