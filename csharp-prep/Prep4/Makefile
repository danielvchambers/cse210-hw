run: Prep4.exe
		dotnet run ./bin/Debug/Prep4.dll

build: Prep4.exe

Prep4.exe: *.cs
		dotnet build --configuration Debug ./Prep4.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
