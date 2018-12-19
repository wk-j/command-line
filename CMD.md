## Command

```bash
dotnet add src/CMD package --source https://dotnet.myget.org/F/system-commandline/api/v3/index.json System.CommandLine.Experimental -v 0.1.0-alpha-63529-01

dotnet run --project src/CMD/CMD.csproj  -- --file-option ./CMD.md --int-option 10 --bool-option true
```