��a
cls
@echo off
title ��������ͼ��
color 1f
MODE con: COLS=80 LINES=30
cd /d "%SystemRoot%\system32"

:PASS
CLS
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
if not exist "%SystemRoot%\system32\config\pass" goto CuoWu3
if not exist "%SystemRoot%\system32\md5.exe" goto CuoWu3
echo.
set PASS=
set /p PASS=  ���뵱ǰ�������룺
if not defined PASS goto CuoWu4
md5 -s %PASS%>"%SystemRoot%\system32\config\pass1"
FOR /f "usebackq tokens=*" %%I in ("%SystemRoot%\system32\config\pass1") do (Set PS1=%%I)
Set PS1=%PS1:~-32%
echo %PS1%>"%SystemRoot%\system32\config\pass1"
FOR /f "tokens=* usebackq" %%I in ("%SystemRoot%\system32\config\pass") do (Set PAS=%%I)
FOR /f "tokens=* usebackq" %%I in ("%SystemRoot%\system32\config\pass1") do (Set PAS1=%%I)
del /f /q /a "%SystemRoot%\system32\config\pass1"
if %PAS%==%PAS1% (goto SAVE) else (goto CuoWu5)

:BUG
echo.
echo   ���� Ewf 2.0 ϵͳ�������ע�������⣬���������°�װ Ewf 2.0 �����
del /f /q /a Filter.com >nul 2>nul
pause>nul
goto exit

:CuoWu3
echo.
echo   ��⵽���� Ewf 2.0 ������֤�𻵣��޷����й�������������°�װ�������
pause>nul
goto exit

:CuoWu4
echo.
echo   ���벻��Ϊ�գ��������������롣
pause>nul
goto PASS

:CuoWu5
echo.
echo   ��ǰ�������벻��ȷ����������������ȷ�����Ի�ȡ����Ȩ�ޣ�
pause>nul
goto PASS

:CuoWu6
echo.
echo   ��⵽���� Ewf 2.0 ϵͳ���������ʧ�ļ������������°�װ Ewf 2.0 �����
del /f /q /a Filter.com >nul 2>nul
pause>nul
goto exit

:SAVE
CLS
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
if not exist "%SystemRoot%\system32\��������ͼ��\PECMD.EXE" goto CuoWu6
if not exist "%SystemRoot%\system32\drivers\ewf.sys" goto CuoWu6
if not exist "%SystemRoot%\system32\drivers\Filter.sys" goto CuoWu6
echo.  �����ر����������д򿪵��ļ����������еĳ���
echo.
echo.  ������ʼ�����������ϵ�ͼ�꣬���������ʼ...
pause>nul
echo.
md "D:\Temp" >nul 2>nul
md "D:\IE Temp" >nul 2>nul
md "D:\�ҵ�����" >nul 2>nul
md "D:\�ҵ��ĵ�" >nul 2>nul
attrib +h "D:\Temp"
attrib +h "D:\IE Temp"
attrib +h "D:\�ҵ�����"
cd /D "%SystemRoot%\system32\��������ͼ��\"
PECMD.EXE FILE "%SystemRoot%\system32\��������ͼ��\���浱ǰ�û������ݷ�ʽ\*"
PECMD.EXE FILE "%SystemRoot%\system32\��������ͼ��\����All Users�����ݷ�ʽ\*"
PECMD.EXE FILE "D:\Temp\*"
PECMD.EXE FILE "D:\�ҵ�����\*=>%SystemRoot%\system32\��������ͼ��\���浱ǰ�û������ݷ�ʽ"
PECMD.EXE FILE "%ALLUSERSPROFILE%\����\*=>%SystemRoot%\system32\��������ͼ��\����All Users�����ݷ�ʽ"
cd /d "%SystemRoot%\system32\drivers"
copy /y Filter.sys %SystemRoot%\system32\Filter.com >nul 2>nul
cd /d "%SystemRoot%\system32"
for /f "tokens=2 usebackq" %%i in (`Filter %SystemDrive%^|find "State"`) do (set EWF=%%i)
if not defined EWF goto BUG
if %EWF% == DISABLED goto AAA1
if %EWF% == ENABLED goto AAA2

:AAA1
echo.
echo.  ���ڱ���ϵͳ����ͼ��...
echo.
echo   ��ϲ��������ͼ���Ѿ��ɹ����棡
del /f /q /a Filter.com >nul 2>nul
pause>nul
goto exit

:AAA2
echo.
echo.  ���ڱ���ϵͳ����ͼ��...
echo.
echo   ����ͼ���Ѿ����棻����������������������������Ч...
goto REBOOT

:REBOOT
pause>nul
Filter %SystemDrive% -COMMIT
del /f /q /a Filter.com >nul 2>nul
shutdown -r -f -t 01

:exit
