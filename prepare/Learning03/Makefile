run: Learning02.exe
		dotnet run ./bin/Debug/Learning02.dll

build: Learning02.exe

Learning02.exe: *.cs
		dotnet build --configuration Debug ./Learning02.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary

clean:
		rm -rf ./bin ./obj

rebuild: clean build
