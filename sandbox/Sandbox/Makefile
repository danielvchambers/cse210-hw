run: Sandbox.exe
		dotnet run ./bin/Debug/Learning02.dll

build: Sandbox.exe

Sandbox.exe: *.cs
		dotnet build --configuration Debug ./Sandbox.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
