; CMDLauncher Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

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

InstallDir $WINDIR

OutFile "bin\Release\CMDLauncher-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "CMDLauncher Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\CMDLauncher.exe"
  WriteUninstaller "CMDLauncher-Uninst.exe"
SectionEnd

Section "CMDLauncher Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\CMDLauncher Options.lnk" "$INSTDIR\CMDLauncher.exe" "" "$INSTDIR\CMDLauncher.exe" "" "" "" "CMDLauncher Options"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall CMDLauncher.lnk" "$INSTDIR\CMDLauncher-Uninst.exe" "" "" "" "" "" "Uninstall CMDLauncher"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

SubSection "Open in CMDLauncher"
  Section "Add to Open With menu"
    WriteRegStr HKCR "Applications\Applications\CMDLauncher.exe\DefaultIcon" "" "%SystemRoot%\\System32\\imageres.dll,-68"
    WriteRegStr HKCR "Applications\CMDLauncher.exe\shell\open\command" "" "$\"$INSTDIR\CMDLauncher.exe$\" $\"%1$\""
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.bat\OpenWithList" "j" "CMDLauncher.exe"
  SectionEnd
  
  Section "Set as default program"
    WriteRegStr HKCR "Applications\Applications\CMDLauncher.exe\DefaultIcon" "" "%SystemRoot%\\System32\\imageres.dll,-68"
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
      ExecShell "open" "https://github.com/Walkman100/CMDLauncher/blob/master/README.md#cmdlauncher-"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\CMDLauncher-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\CMDLauncher.exe"
  
  Delete "$SMPROGRAMS\DeavmiOSS\CMDLauncher Options.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall CMDLauncher.lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall CMDLauncher. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd