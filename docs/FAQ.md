#FAQ

##Why does the project use an installer instead of the Visual Studio Extension Manager or NuGet?

This project is a Visual Studio Custom Tool. Custom Tools must be COM registered in the Windows Registry and registered with Visual Studio 2010. Neither Visual Studio Extension Manager nor NuGet provide a facility to accomplish this registration. The Extension Manager can install Visual Studio Packages. This custom tool is not a package nor could it be converted to a package because it doesn't integrate into Visual Studio like a package. NuGet performs actions to projects. Because this custom tool is not project specific, NuGet wouldn't work either.
Last edited Nov 10, 2011 at 7:21 AM by pwolfe, version 1