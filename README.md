## Console App on top of DNX with tests written in MSTest runner

The .NET Execution Environment (DNX) is used to build and run .NET projects and relies on .NET Version Manager (DNVM). Use DNVM to install DNX for the full .NET Framework or .NET Core.

### Why
DNX was developed next to ASP.NET Core 1.0 (formerly known as ASP.NET 5 [1]). Currently, many sources claims that there is no way to write tests for code based on DNX with MSTest runner (just to clarify, xUnit is recommended by Microsoft and community right now).

### How
I've started with simple console application made in Visual Studio 2013. 
Later, I've created configuration files required by DNX and prepared basic setup to build solution by AppVeyor CI [2].
In the end, I've cleaned up Visual Studio related files to make it pure DNX project.
No *.sln or *.xproj files requires to change build script settings. Set the following as cmd script in AppVeyor build settings panel.
```
dnu build src\DNXConsoleApp test\DNXConsoleApp.MSTest
```

### Usage
Run the console or terminal and type the following ones:
```
dnu restore
dnu build src\DNXConsoleApp test\DNXConsoleApp.MSTest
dnu publish src\DNXConsoleApp
dnx -p test\DNXConsoleApp.MSTest test
```
or check the appveyor.yml for further details.

### MSTest.Runner.Dnx
It's the missing key component in the application assembly that can be acquired via NuGet. Has been released in the end of 2015, so it's quite obvious some devs missed it, especially with the release of ASP.NET 5 and endorsing xUnit by Microsoft. 


[1] https://docs.asp.net/en/latest/dnx/overview.html
[2] GitHub repository is integrated with AppVeyor (free cloud CI with native .NET support).

[![Build status](https://ci.appveyor.com/api/projects/status/5rwqkrof5qnc53sb?svg=true)](https://ci.appveyor.com/project/bskorupski/appveyor-dnx-mstest)