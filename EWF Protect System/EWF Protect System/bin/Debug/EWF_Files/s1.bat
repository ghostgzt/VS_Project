if exist "%SystemRoot%\bootstat.dat" del /f /q /a %SystemRoot%\bootstat.dat >nul 2>nul
type nul >%SystemRoot%\bootstat.dat
regedit /s ewf.reg
if exist "%SystemRoot%\system32\ewfinit.dll" del /f /q /a %SystemRoot%\system32\ewfinit.dll >nul 2>nul
if exist "%SystemRoot%\system32\ewfdll.dll" del /f /q /a %SystemRoot%\system32\ewfdll.dll >nul 2>nul
copy /y ewfinit.dll %SystemRoot%\system32\ >nul 2>nul
copy /y ewfdll.dll %SystemRoot%\system32\ >nul 2>nul
copy /y ewf.sys %SystemRoot%\system32\drivers\ >nul 2>nul
copy /y ewf.inf %SystemRoot%\inf\ >nul 2>nul
copy /y Filter.sys %SystemRoot%\system32\drivers\ >nul 2>nul
copy /y Filter.sys %SystemRoot%\system32\drivers\ >nul 2>nul
copy /y Filter.sys %SystemRoot%\system32\Filter.exe >nul 2>nul
set Volume=1
:_RegAdd1
echo Windows Registry Editor Version 5.00>"%SystemRoot%\system32\Volume.reg"
echo.>>"%SystemRoot%\system32\Volume.reg"
echo [HKEY_LOCAL_MACHINE\system\ControlSet001\Services\EWF\Parameters\Protected\Volume%Volume%]>>"%SystemRoot%\system32\Volume.reg"
echo "Type"=dword:00000001>>"%SystemRoot%\system32\Volume.reg"
echo "ArcName"="multi(0)disk(0)rdisk(0)partition(%Volume%)">>"%SystemRoot%\system32\Volume.reg"
echo "Enabled"=dword:00000000>>"%SystemRoot%\system32\Volume.reg"
regedit /s "%SystemRoot%\system32\Volume.reg"
set /a Volume+=1
if %Volume% LSS 13 goto _RegAdd1
set Volume=13
set Volume'=1
:_RegAdd2
echo Windows Registry Editor Version 5.00>"%SystemRoot%\system32\Volume.reg"
echo.>>"%SystemRoot%\system32\Volume.reg"
echo [HKEY_LOCAL_MACHINE\system\ControlSet001\Services\EWF\Parameters\Protected\Volume%Volume%]>>"%SystemRoot%\system32\Volume.reg"
echo "Type"=dword:00000001>>"%SystemRoot%\system32\Volume.reg"
echo "ArcName"="multi(0)disk(0)rdisk(1)partition(%Volume'%)">>"%SystemRoot%\system32\Volume.reg"
echo "Enabled"=dword:00000000>>"%SystemRoot%\system32\Volume.reg"
regedit /s "%SystemRoot%\system32\Volume.reg"
set /a Volume+=1
set /a Volume'+=1
if %Volume% LSS 25 goto _RegAdd2
set Volume=25
set Volume'=1
:_RegAdd3
echo Windows Registry Editor Version 5.00>"%SystemRoot%\system32\Volume.reg"
echo.>>"%SystemRoot%\system32\Volume.reg"
echo [HKEY_LOCAL_MACHINE\system\ControlSet001\Services\EWF\Parameters\Protected\Volume%Volume%]>>"%SystemRoot%\system32\Volume.reg"
echo "Type"=dword:00000001>>"%SystemRoot%\system32\Volume.reg"
echo "ArcName"="multi(0)disk(0)rdisk(2)partition(%Volume'%)">>"%SystemRoot%\system32\Volume.reg"
echo "Enabled"=dword:00000000>>"%SystemRoot%\system32\Volume.reg"
regedit /s "%SystemRoot%\system32\Volume.reg"
set /a Volume+=1
set /a Volume'+=1
if %Volume% LSS 37 goto _RegAdd3
del /f /q /a "%SystemRoot%\system32\Volume.reg" >nul 2>nul
