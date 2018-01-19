var targetHello = Argument("target", "Default");
var targetBuild = Argument("target", "Build");
 
Task("Default")
    .Does(() =>
    {
        Information("Hello World! Lets build? Sure.");
    });
 
RunTarget(targetHello);

Task("Build")
    .Does(() =>
    {
        MSBuild("./CakeAutomation.sln");
    });

RunTarget(targetBuild);