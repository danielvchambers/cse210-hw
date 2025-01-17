run: Prep3.exe
		dotnet run ./bin/Debug/Prep3.dll

build: Prep3.exe

Prep3.exe: *.cs
		dotnet build --configuration Debug ./Prep3.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
