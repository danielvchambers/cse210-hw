run: Develop03.exe
		dotnet run ./bin/Debug/Develop03.dll

build: Develop03.exe

Develop03.exe: *.cs
		dotnet build --configuration Debug ./Develop03.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
