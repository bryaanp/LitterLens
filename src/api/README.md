# LitterLens API

Run from the repository root:

```powershell
dotnet run --project src/api/LitterLens.Api.csproj
```

Check `http://localhost:5050/api/health` in a browser or with `Invoke-RestMethod`.
Currently exposes only process health. Authentication, persistence, ingest, and
review routes remain planned.
