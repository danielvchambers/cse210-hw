run: Prep1.exe
		dotnet run ./bin/Debug/Prep1.dll

build: Prep1.exe

Prep1.exe: *.cs
		dotnet build --configuration Debug ./Prep1.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
