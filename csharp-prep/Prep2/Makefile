run: Prep2.exe
		dotnet run ./bin/Debug/Prep2.dll

build: Prep2.exe

Prep2.exe: *.cs
		dotnet build --configuration Debug ./Prep2.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
