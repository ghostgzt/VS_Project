@echo off
setlocal enabledelayedexpansion
for %%i in (C D E F G H I J K L M N O P Q R S T U V W X Y Z) do (fsutil fsinfo drivetype %%i:|find "¹Ì¶¨">nul && for /f "delims=" %%j in ("%%i") do set partition=!partition! %%j:)
cd /d "%SystemRoot%\system32"
setlocal enabledelayedexpansion
for %%j in (%partition%) do (fsutil fsinfo drivetype %%j|find "¹Ì¶¨">nul && Filter %%j|find "ENABLED">nul && for /f "delims=" %%k in ("%%j") do set partition1=!partition1! %%k)
setlocal disabledelayedexpansion
setlocal enabledelayedexpansion
for %%j in (%partition%) do (fsutil fsinfo drivetype %%j|find "¹Ì¶¨">nul && Filter %%j|find "DISABLED">nul && for /f "delims=" %%k in ("%%j") do set partition2=!partition2! %%k)
setlocal disabledelayedexpansion
echo %partition1% - %partition2%>%TEMP%\$.txt
