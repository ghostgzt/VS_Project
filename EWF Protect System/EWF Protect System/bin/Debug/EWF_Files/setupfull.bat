@echo off
title ��װ Enhanced Write Filter 2.0 ϵͳ����
color 1f
MODE con: COLS=80 LINES=30
SET Var1=%0
IF '^%Var1:~0,1%'=='^"' SET Var1=%Var1:~1,-1%
FOR /f "delims=" %%I in ("%Var1%") do Set TTP=%%~dpI
SET TTP=%TTP:~0,-1%
for /f "tokens=3 usebackq" %%i in (`VER^|find "Windows"`) do (set WIN=%%i)
if not defined WIN goto NO
if %WIN%==XP (goto Start) else (goto NO)
for /f "tokens=*" %%i in ('fsutil fsinfo drivetype d:') do (
    echo %%i|find "�̶�">nul && goto Start || goto Start'
)

:Start
cls
echo.
echo.           ��������������������������������������������������������
echo.           ��             Enhanced Write Filter 2.0              ��
echo.           ��                                                    ��
echo.           ��  �� �ߣ�ޭ���ء�����ѧ  �� ��  caozhi256@163.com   ��
echo.           ��                                                    ��
echo.           ��  �� ��֧�����������������ʹ�������������Ȩ��   ��
echo.           ��                                                    ��
echo.           ��         ��΢��˾���������ú�24Сʱ��ɾ����ʹ��   ��
echo.           ��                                                    ��
echo.           ��         ����������������Ը�����˴���˳��򴿴��   ��
echo.           ��                                                    ��
echo.           ��         �ڰ��ã�����Դ˳е��κη��պͷ������Ρ�   ��
echo.           ��                                                    ��
echo.           ��������������������������������������������������������
echo.
echo.  ���ڵ���ϵͳ����......
echo.
RD /Q /S Min >nul 2>nul
md "D:\Temp" >nul 2>nul
md "D:\IE Temp" >nul 2>nul
md "D:\�ҵ�����" >nul 2>nul
md "D:\�ҵ��ĵ�" >nul 2>nul
attrib +h "D:\Temp"
attrib +h "D:\IE Temp"
attrib +h "D:\�ҵ�����"
if exist "%SystemRoot%\system32\��������ͼ��" rd /q /s "%SystemRoot%\system32\��������ͼ��"
md "%SystemRoot%\system32\��������ͼ��" >nul 2>nul
md "%SystemRoot%\system32\��������ͼ��\���浱ǰ�û������ݷ�ʽ" >nul 2>nul
md "%SystemRoot%\system32\��������ͼ��\����All Users�����ݷ�ʽ" >nul 2>nul
attrib +h "%SystemRoot%\system32\��������ͼ��"
reg add HKCU\Environment /v "TEMP" /d "D:\Temp" /f >nul 2>nul
reg add HKCU\Environment /v "TMP" /d "D:\Temp" /f >nul 2>nul
set PASS=B317D75C2A5ED99179A01C611897F4CB
echo %PASS%>"%SystemRoot%\system32\config\pass"
Desktop_Path.exe
PECMD.EXE WAIT 4000
FOR /f "tokens=* usebackq" %%I in ("%SystemRoot%\system32\Desktop.txt") do (Set TP=%%I)
del /f /q "%SystemRoot%\system32\Desktop.txt" >nul 2>nul
PECMD.EXE FILE "%TP%\*=>%SystemRoot%\system32\��������ͼ��\���浱ǰ�û������ݷ�ʽ\"
PECMD.EXE FILE "%ALLUSERSPROFILE%\����\*=>%SystemRoot%\system32\��������ͼ��\����All Users�����ݷ�ʽ"
copy /y PECMD.EXE "%SystemRoot%\system32\��������ͼ��\" >nul 2>nul
copy /y md5.exe "%SystemRoot%\system32\" >nul 2>nul
SetPageFile.exe /del all /set d 0 0
del /f /q PECMD.EXE >nul 2>nul
cls
echo.
echo.           ��������������������������������������������������������
echo.           ��             Enhanced Write Filter 2.0              ��
echo.           ��                                                    ��
echo.           ��  �� �ߣ�ޭ���ء�����ѧ  �� ��  caozhi256@163.com   ��
echo.           ��                                                    ��
echo.           ��  �� ��֧�����������������ʹ�������������Ȩ��   ��
echo.           ��                                                    ��
echo.           ��         ��΢��˾���������ú�24Сʱ��ɾ����ʹ��   ��
echo.           ��                                                    ��
echo.           ��         ����������������Ը�����˴���˳��򴿴��   ��
echo.           ��                                                    ��
echo.           ��         �ڰ��ã�����Դ˳е��κη��պͷ������Ρ�   ��
echo.           ��                                                    ��
echo.           ��������������������������������������������������������
echo.
echo.  ���ڰ�װ Enhanced Write Filter 2.0 ......
echo.
if exist "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����" RD /Q /S "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����"
md "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����" >nul 2>nul
SHORTCUT.EXE -f -t Ewf_On.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\a������ Ewf 2.0 ����" -d .\
SHORTCUT.EXE -f -t Ewf_Off.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\b���ر� Ewf 2.0 ����" -d .\
SHORTCUT.EXE -f -t Data_Save.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\c���������ݱ��" -d .\
SHORTCUT.EXE -f -t Look.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\d���鿴 Ewf 2.0 ״̬" -d .\
SHORTCUT.EXE -f -t Desktop_Rest.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\e���ָ�����ͼ��" -d .\
SHORTCUT.EXE -f -t Desktop_Save.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\f����������ͼ��" -d .\
SHORTCUT.EXE -f -t Pass.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\g���������" -d .\
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
cd /D "%SystemRoot%\system32\��������ͼ��\"
PECMD.EXE FILE "D:\�ҵ�����\*"
PECMD.EXE FILE "D:\Temp\*"
PECMD.EXE FILE "%SystemRoot%\system32\��������ͼ��\����All Users�����ݷ�ʽ\*=>%ALLUSERSPROFILE%\����"
PECMD.EXE FILE "%SystemRoot%\system32\��������ͼ��\���浱ǰ�û������ݷ�ʽ\*=>D:\�ҵ�����\"
PECMD.EXE WAIT 3000
cd /D %TTP%
del /f /q /a rd.bat >nul 2>nul
del /f /q /a ewf.inf >nul 2>nul
del /f /q /a ewf.sys >nul 2>nul
del /f /q /a Desktop_Path.exe >nul 2>nul
del /f /q /a SetPageFile.exe >nul 2>nul
del /f /q /a ewf.reg >nul 2>nul
del /f /q /a ewf'.reg >nul 2>nul
del /f /q /a SHORTCUT.EXE >nul 2>nul
del /f /q /a md5.exe >nul 2>nul
del /f /q /a ewfinit.dll >nul 2>nul
del /f /q /a ewfdll.dll >nul 2>nul
del /f /q /a Filter.sys >nul 2>nul
attrib +h "%TTP%"
attrib +h "%TTP%\*"
attrib -h "%TTP%\setup.bat"
attrib -h "%TTP%\reboot.bat"
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
call reboot.bat
del %0
goto exit

:Start'
cls
echo.
echo.           ��������������������������������������������������������
echo.           ��             Enhanced Write Filter 2.0              ��
echo.           ��                                                    ��
echo.           ��  �� �ߣ�ޭ���ء�����ѧ  �� ��  caozhi256@163.com   ��
echo.           ��                                                    ��
echo.           ��  �� ��֧�����������������ʹ�������������Ȩ��   ��
echo.           ��                                                    ��
echo.           ��         ��΢��˾���������ú�24Сʱ��ɾ����ʹ��   ��
echo.           ��                                                    ��
echo.           ��         ����������������Ը�����˴���˳��򴿴��   ��
echo.           ��                                                    ��
echo.           ��         �ڰ��ã�����Դ˳е��κη��պͷ������Ρ�   ��
echo.           ��                                                    ��
echo.           ��������������������������������������������������������
echo.
echo.  ��С��װ Enhanced Write Filter 2.0 ......
echo.
copy /y .\Min\Ewf_On.bat Ewf_On.bat >nul 2>nul
copy /y .\Min\Ewf_Off.bat Ewf_Off.bat >nul 2>nul
copy /y .\Min\Data_Save.bat Data_Save.bat >nul 2>nul
copy /y .\Min\Look.bat Look.bat >nul 2>nul
copy /y .\Min\Pass.bat Pass.bat >nul 2>nul
RD /Q /S Min >nul 2>nul
if exist "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����" RD /Q /S "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����"
md "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����" >nul 2>nul
SHORTCUT.EXE -f -t Ewf_On.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\a������ Ewf 2.0 ������C�̣�" -d .\
SHORTCUT.EXE -f -t Ewf_Off.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\b���ر� Ewf 2.0 ������C�̣�" -d .\
SHORTCUT.EXE -f -t Data_Save.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\c������ C ������" -d .\
SHORTCUT.EXE -f -t Look.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\d���鿴 Ewf 2.0 ״̬" -d .\
SHORTCUT.EXE -f -t Pass.bat -n "%USERPROFILE%\����ʼ���˵�\����\Ewf 2.0 ϵͳ����\e���������" -d .\
if exist "%SystemRoot%\bootstat.dat" del /f /q /a %SystemRoot%\bootstat.dat >nul 2>nul
type nul >%SystemRoot%\bootstat.dat
regedit /s ewf'.reg
if exist "%SystemRoot%\system32\ewfinit.dll" del /f /q /a %SystemRoot%\system32\ewfinit.dll >nul 2>nul
if exist "%SystemRoot%\system32\ewfdll.dll" del /f /q /a %SystemRoot%\system32\ewfdll.dll >nul 2>nul
copy /y ewfinit.dll %SystemRoot%\system32\ >nul 2>nul
copy /y ewfdll.dll %SystemRoot%\system32\ >nul 2>nul
copy /y ewf.sys %SystemRoot%\system32\drivers\ >nul 2>nul
copy /y ewf.inf %SystemRoot%\inf\ >nul 2>nul
copy /y Filter.sys %SystemRoot%\system32\drivers\ >nul 2>nul
copy /y md5.exe "%SystemRoot%\system32\" >nul 2>nul
set PASS=B317D75C2A5ED99179A01C611897F4CB
echo %PASS%>"%SystemRoot%\system32\config\pass"
cd /D %TTP%
PECMD.EXE WAIT 3000
del /f /q /a rd.bat >nul 2>nul
del /f /q /a ewf.inf >nul 2>nul
del /f /q /a ewf.sys >nul 2>nul
del /f /q /a Desktop_Path.exe >nul 2>nul
del /f /q /a SetPageFile.exe >nul 2>nul
del /f /q /a ewf.reg >nul 2>nul
del /f /q /a ewf'.reg >nul 2>nul
del /f /q /a SHORTCUT.EXE >nul 2>nul
del /f /q /a md5.exe >nul 2>nul
del /f /q /a ewfinit.dll >nul 2>nul
del /f /q /a ewfdll.dll >nul 2>nul
del /f /q /a Filter.sys >nul 2>nul
del /f /q /a Desktop_Rest.bat >nul 2>nul
del /f /q /a Desktop_Save.bat >nul 2>nul
attrib +h "%TTP%"
attrib +h "%TTP%\*"
attrib -h "%TTP%\setup.bat"
attrib -h "%TTP%\reboot.bat"
set Volume=1
:_RegAdd4
echo Windows Registry Editor Version 5.00>"%SystemRoot%\system32\Volume.reg"
echo.>>"%SystemRoot%\system32\Volume.reg"
echo [HKEY_LOCAL_MACHINE\system\ControlSet001\Services\EWF\Parameters\Protected\Volume%Volume%]>>"%SystemRoot%\system32\Volume.reg"
echo "Type"=dword:00000001>>"%SystemRoot%\system32\Volume.reg"
echo "ArcName"="multi(0)disk(0)rdisk(0)partition(%Volume%)">>"%SystemRoot%\system32\Volume.reg"
echo "Enabled"=dword:00000000>>"%SystemRoot%\system32\Volume.reg"
regedit /s "%SystemRoot%\system32\Volume.reg"
set /a Volume+=1
if %Volume% LSS 13 goto _RegAdd4
set Volume=13
set Volume'=1
:_RegAdd5
echo Windows Registry Editor Version 5.00>"%SystemRoot%\system32\Volume.reg"
echo.>>"%SystemRoot%\system32\Volume.reg"
echo [HKEY_LOCAL_MACHINE\system\ControlSet001\Services\EWF\Parameters\Protected\Volume%Volume%]>>"%SystemRoot%\system32\Volume.reg"
echo "Type"=dword:00000001>>"%SystemRoot%\system32\Volume.reg"
echo "ArcName"="multi(0)disk(0)rdisk(1)partition(%Volume'%)">>"%SystemRoot%\system32\Volume.reg"
echo "Enabled"=dword:00000000>>"%SystemRoot%\system32\Volume.reg"
regedit /s "%SystemRoot%\system32\Volume.reg"
set /a Volume+=1
set /a Volume'+=1
if %Volume% LSS 25 goto _RegAdd5
set Volume=25
set Volume'=1
:_RegAdd6
echo Windows Registry Editor Version 5.00>"%SystemRoot%\system32\Volume.reg"
echo.>>"%SystemRoot%\system32\Volume.reg"
echo [HKEY_LOCAL_MACHINE\system\ControlSet001\Services\EWF\Parameters\Protected\Volume%Volume%]>>"%SystemRoot%\system32\Volume.reg"
echo "Type"=dword:00000001>>"%SystemRoot%\system32\Volume.reg"
echo "ArcName"="multi(0)disk(0)rdisk(2)partition(%Volume'%)">>"%SystemRoot%\system32\Volume.reg"
echo "Enabled"=dword:00000000>>"%SystemRoot%\system32\Volume.reg"
regedit /s "%SystemRoot%\system32\Volume.reg"
set /a Volume+=1
set /a Volume'+=1
if %Volume% LSS 37 goto _RegAdd6
del /f /q /a "%SystemRoot%\system32\Volume.reg" >nul 2>nul
call reboot.bat
del %0
goto exit

:NO
cls
echo.
echo.           ��������������������������������������������������������
echo.           ��             Enhanced Write Filter 2.0              ��
echo.           ��                                                    ��
echo.           ��  �� �ߣ�ޭ���ء�����ѧ  �� ��  caozhi256@163.com   ��
echo.           ��                                                    ��
echo.           ��  �� ��֧�����������������ʹ�������������Ȩ��   ��
echo.           ��                                                    ��
echo.           ��         ��΢��˾���������ú�24Сʱ��ɾ����ʹ��   ��
echo.           ��                                                    ��
echo.           ��         ����������������Ը�����˴���˳��򴿴��   ��
echo.           ��                                                    ��
echo.           ��         �ڰ��ã�����Դ˳е��κη��պͷ������Ρ�   ��
echo.           ��                                                    ��
echo.           ��������������������������������������������������������
echo.
echo.  ��⵽���Ĳ���ϵͳ���� Windows XP ����װ������֧�֣������˳�...
echo.
echo.  �������������Ѿ��ͷŵ�ϵͳ�е�������ʱ�ļ�...
pause>nul
ECHO %TTP%>"%SystemRoot%\system32\Path.txt"
cd..
copy /y "%TTP%\rd.bat" rd.bat >nul 2>nul
call rd.bat
goto exit

:exit
