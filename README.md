Knowledge iOS Back-end .NET C#
- warp
- asdf
  
How to install asdf
- brew install asdf
- asdf plugin add dotnet-core 
- asdf install dotnet-core 9.0.306  
- dotnet —-version
- dotnet —-info
-https://source.dot.net/#Microsoft.Build.Tasks.Core/Interop.cs,b44e34d7320db3d1

Create Project Hello
- dotnet new console -o Hello -n AYCAP.Hello
- /Users/11389855/Hello/AYCAP.Hello.csproj
- dotnet restore
- dotnet build
- dotnet build -c Release
- dotnet run
- dotnet run bin/Release/net9.0/AYCAP.Hello.dll
- code .
- dotnet new webapi --help
  
Create Project HelloApi
- dotnet new webapi -o AYCAP.HelloApi --use-program-main --use-controllers
- cd AYCAP.HelloApi/
- dotnet run
https://www.nuget.org/packages/Swashbuckle.AspNetCore.Swagger/10.0.1#versions-body-tab
- dotnet add package Swashbuck.AspNetCore --version 9.0.6
- dotnet new webapi -o AYCAP.MinimalApi
