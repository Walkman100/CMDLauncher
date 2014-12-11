; CMDLauncher Installer NSIS Script
; get NSIS at http://tenet.dl.sourceforge.net/project/nsis/NSIS%202/2.46/nsis-2.46-setup.exe
; As a program that all Power PC users should have, Notepad ++ is recommended to edit this file

AddBrandingImage top 20
Icon CmdScript.ico
Caption "CMDLauncher Installer"
Name "CMDLauncher"
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing CMDLauncher. If you understand the notice, click the checkbox below and click Next."

InstallDir $SYSDIR

OutFile "bin\Release\CMDLauncher-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Executable"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\CMDLauncher.exe"
SectionEnd

SubSection "Open in CMDLauncher"
  Section "Add to Open With menu"
    WriteRegStr HKCR "Applications\CMDLauncher.exe\shell\open\command" "" "$\"$INSTDIR\CMDLauncher.exe$\" $\"%1$\""
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.bat\OpenWithList" "j" "CMDLauncher.exe"
  SectionEnd
  
  Section "Set as default program"
    WriteRegStr HKCR "Applications\CMDLauncher.exe\shell\open\command" "" "$\"$INSTDIR\CMDLauncher.exe$\" $\"%1$\""
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.bat\UserChoice" "Progid" "Applications\CMDLauncher.exe"
  SectionEnd
SubSectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install CMDLauncher. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetBrandingImage "[/RESIZETOFIT] CmdScript.ico"
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/CMDLauncher/blob/master/README.md#CMDLauncher-"
    NoReadme:
FunctionEnd