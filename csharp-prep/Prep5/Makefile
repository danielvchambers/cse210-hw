run: Prep5.exe
		dotnet run ./bin/Debug/Prep5.dll

build: Prep5.exe

Prep5.exe: *.cs
		dotnet build --configuration Debug ./Prep5.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
