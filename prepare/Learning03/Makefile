run: Learning03.exe
		dotnet run ./bin/Debug/Learning03.dll

build: Learning03.exe

Learning03.exe: *.cs
		dotnet build --configuration Debug ./Learning03.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
