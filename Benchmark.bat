RMDIR /S /Q .\AbbaGame\bin\Benchmarks
RMDIR /S /Q .\BenchmarkDotNet.Artifacts
dotnet build -c Release -o .\AbbaGame\bin\Benchmarks .\AbbaGame\AbbaGame.csproj
dotnet .\AbbaGame\bin\Benchmarks\AbbaGame.dll
xcopy /S /Q /Y /F .\BenchmarkDotNet.Artifacts\results\*-report-github.md .\Benchmark.md
pause