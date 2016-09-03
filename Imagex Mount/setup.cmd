@echo off
color f0
echo +++++++ImageX Setup+++++++++
copy /y IMAGEX.EXE %windir%\system32
copy /y INTLCFG.EXE %windir%\system32
copy /y WIMFLTR.INF %windir%\system32
copy /y WIMFLTR.SYS %windir%\system32
copy /y WIMGAPI.DLL %windir%\system32
rundll32.exe setupapi,InstallHinfSection DefaultInstall 132 %windir%\system32\WIMFLTR.INF
pause & exit 