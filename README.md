# MyPluginDemo by eMeL

A simple and great way to make a plugin DLL for a C# application. 

You can run a demo from _EXE_ directory.

Copy theese three files to a directory and unzip the ZIP to EXE (because GIT don't store exe file)

The MyPluginDemo.exe calls code of MyPluginClasses.dll.
This DLL load to exe at runtime, it isn't a static bound linkage. (So it replaceable too.)

The MyPluginInterface.dll is the connecting link between them.
It's an interface definition only, but both (MyPluginDemo.exe and MyPluginClasses.dll) known it, but thees two don't know eachothers. 

The interface only tells call information to exe, but the code staying in MyPluginClasses.dll.
