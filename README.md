# HTTP archive (de)serializer for .NET

Library to make it easy to work with HTTP archives in .NET.

[![Build status](https://ci.appveyor.com/api/projects/status/s26upfa1fgi7jlnw/branch/master?svg=true)](https://ci.appveyor.com/project/Nalanae/har-dotnet/branch/master)

## HTTP archives

The HTTP archive format or HAR, is a JSON-formatted archival format most known for logs of a web browser's interaction with a site. They can be used for a wide range of applications, including, but not limited to:
  - Performance analytics
  - Usability testing and analysis
  - Automated security testing

HAR specification: https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html

## Setup with NuGet

Execute the following command in your Package Manager Console, or search for "HAR".

```PowerShell
PM> Install-Package HAR
```

## Usage

Serializing:

```csharp
var harObject = new Har();
var harJson = Har.Serialize(harObject);
```

Deserializing:

```csharp
var harJson = "{ log: { /* HAR log */ } }";
var harObject = Har.Deserialize(harJson);
```

## Future
  - Reading from and writing to files.
  - Support zipped HAR files (ZHAR).
