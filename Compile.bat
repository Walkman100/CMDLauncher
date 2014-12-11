@echo off

%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe /property:Configuration=Release CMDLauncher.sln

%ProgramFiles%\NSIS\makensis.exe "NSIS Installer for CMDLauncher.nsi"
ren bin\Release\CMDLauncher.exe CMDLauncher-Portable.exe

explorer.exe "%~dp0bin\Release"