��a
cls
@echo off
title �������
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
if not exist "%SystemRoot%\system32\config\pass" goto BUG5
if not exist "%SystemRoot%\system32\md5.exe" goto BUG5
echo.
echo   ��ʼ����Ϊ��caozhi256������9���ַ���Ҳ�����ҵ��������ˡ��뾡��������룡
echo.
set PASS=
set /p PASS=  ���뵱ǰ���룺
if not defined PASS goto BUG1
md5 -s %PASS%>"%SystemRoot%\system32\config\pass1"
FOR /f "usebackq tokens=*" %%I in ("%SystemRoot%\system32\config\pass1") do (Set PS1=%%I)
Set PS1=%PS1:~-32%
echo %PS1%>"%SystemRoot%\system32\config\pass1"
FOR /f "tokens=* usebackq" %%I in ("%SystemRoot%\system32\config\pass") do (Set PAS=%%I)
FOR /f "tokens=* usebackq" %%I in ("%SystemRoot%\system32\config\pass1") do (Set PAS1=%%I)
del /f /q "%SystemRoot%\system32\config\pass1"
if %PAS%==%PAS1% (goto NEW_PASS) else (goto BUG2)

:NEW_PASS
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
echo   ��ǰ������֤ͨ��������Ȩ�����������롣
echo.
set PASS1=
set /p PASS1=  ����������룺
if not defined PASS1 goto BUG3
echo.
set PASS2=
set /p PASS2=  ȷ�ϸ������룺
if not defined PASS2 goto BUG3
if not "%PASS1%"=="%PASS2%" goto BUG4
md5 -s %PASS1%>"%SystemRoot%\system32\config\pass"
FOR /f "usebackq tokens=*" %%I in ("%SystemRoot%\system32\config\pass") do (Set PS=%%I)
Set PS=%PS:~-32%
echo %PS%>"%SystemRoot%\system32\config\pass"
echo.
echo   ��ϲ������������תΪ Md5 ���Ĵ��棡���μ����������룡
goto SAVE

:BUG1
echo.
echo   ���벻��Ϊ�գ��������������롣
pause>nul
goto PASS

:BUG2
echo.
echo   ��ǰ�������벻��ȷ����������������ȷ�����Ի�ȡ����Ȩ�ޣ�
pause>nul
goto PASS

:BUG3
echo.
echo   ���벻��Ϊ�գ��������������롣
pause>nul
goto NEW_PASS

:BUG4
echo.
echo   ���γ�������벻��ͬ�����������������롣
pause>nul
goto NEW_PASS

:BUG5
echo.
echo   ��⵽���� Ewf 2.0 ������֤�𻵣��޷����й�������������°�װ�������
pause>nul
goto exit

:SAVE
cd /d "%SystemRoot%\system32\drivers"
copy /y Filter.sys %SystemRoot%\system32\Filter.com >nul 2>nul
cd /d "%SystemRoot%\system32"
if not exist "%SystemRoot%\system32\drivers\ewf.sys" goto BUG9
if not exist "%SystemRoot%\system32\��������ͼ��\PECMD.EXE" goto BUG9
if not exist "%SystemRoot%\system32\drivers\Filter.sys" goto BUG9
for /f "tokens=2 usebackq" %%i in (`Filter %SystemDrive%^|find "State"`) do (set EWF=%%i)
if not defined EWF goto BUG6
if %EWF% == DISABLED goto BUG7
if %EWF% == ENABLED goto BUG8

:BUG6
echo.
echo   ���� Ewf 2.0 ϵͳ�������ע��������������𻵣����������°�װ Ewf 2.0 �����
echo.
echo   ����������˳�...
del /f /q Filter.com >nul 2>nul
pause>nul
goto exit

:BUG7
echo.
echo   ����������˳�...
del /f /q Filter.com >nul 2>nul
pause>nul
goto exit

:BUG9
echo.
echo   ��⵽���� Ewf 2.0 ϵͳ���������ʧ�ļ������������°�װ Ewf 2.0 �����
pause>nul
goto exit

:BUG8
echo.
echo   ��⵽��������ϵͳ��������Ҫ�������������������Ч��
echo.
echo   �������������...
pause>nul
Filter %SystemDrive% -COMMIT
del /f /q Filter.com >nul 2>nul
shutdown -r -f -t 01

:exit
