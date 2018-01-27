var targetHello = Argument("target", "Default");
var targetBuild = Argument("target", "Build");
var configuration = Argument("configuration", "Release");
var artifactsDirectory = MakeAbsolute(Directory("./artifacts"));
 
Task("Default")
    .Does(() =>
    {
        Information("Hello World! Lets build? Sure.");
    });
 
RunTarget(targetHello);

Task("Build")
    .Does(() =>
    {
        foreach(var project in GetFiles("./src/**/*.csproj"))
        {
            DotNetCoreBuild(
                project.GetDirectory().FullPath, 
                new DotNetCoreBuildSettings()
                {
                    Configuration = configuration
                });
        }
    });

RunTarget(targetBuild);