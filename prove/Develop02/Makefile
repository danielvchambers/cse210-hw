run: Develop02.exe
		dotnet run ./bin/Debug/Develop02.dll

build: Develop02.exe

Develop02.exe: *.cs
		dotnet build --configuration Debug ./Develop02.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
