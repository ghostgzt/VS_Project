��
@echo off
cls
@echo off
title �鿴 Ewf 2.0 ״̬
color 1f
MODE con: COLS=80 LINES=30
SET Var1=%0
IF '^%Var1:~0,1%'=='^"' SET Var1=%Var1:~1,-1%
FOR /f "delims=" %%I in ("%Var1%") do Set TTP=%%~dpI
SET TTP=%TTP:~0,-1%
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
echo   ���ڲ鿴����ϵͳ����״̬�����Ժ�......
if not exist "%SystemRoot%\system32\drivers\Filter.sys" goto BUG1
if not exist "%SystemRoot%\system32\drivers\ewf.sys" goto BUG1
if not exist "%SystemRoot%\system32\��������ͼ��\PECMD.EXE" goto BUG1
cd /d "%SystemRoot%\system32\drivers"
setlocal enabledelayedexpansion
for %%i in (C D E F G H I J K L M N O P Q R S T U V W X Y Z) do (
fsutil fsinfo drivetype %%i:|find "�̶�">nul && for /f "delims=" %%j in ("%%i") do set partition=!partition! %%j:
)
setlocal disabledelayedexpansion
copy /y Filter.sys %SystemRoot%\system32\Filter.com >nul 2>nul
cd /d "%SystemRoot%\system32"
echo.
echo   ����ϵͳӦ���ܹ������·��������� Ewf 2.0 ϵͳ������
echo.
echo      %partition%
setlocal enabledelayedexpansion
for %%j in (%partition%) do (
fsutil fsinfo drivetype %%j|find "�̶�">nul && Filter %%j|find "ENABLED">nul && for /f "delims=" %%k in ("%%j") do set partition1=!partition1! %%k
)
setlocal disabledelayedexpansion
setlocal enabledelayedexpansion
for %%j in (%partition%) do (
fsutil fsinfo drivetype %%j|find "�̶�">nul && Filter %%j|find "DISABLED">nul && for /f "delims=" %%k in ("%%j") do set partition2=!partition2! %%k
)
setlocal disabledelayedexpansion
if "%partition1%"=="%partition%" goto AAA1
if "%partition2%"=="%partition%" goto AAA2
echo.
echo   ���У�
echo.
echo   �Ѿ����� Ewf 2.0 ϵͳ��������ķ����� %partition1%
echo.
echo   Ewf 2.0 ϵͳ���������ͣ�õķ�����    %partition2%
del /f /q /a Filter.com >nul 2>nul
pause>nul
goto exit

:BUG1
echo.
echo   ��⵽���� Ewf 2.0 ϵͳ���������ʧ�ļ������������°�װ Ewf 2.0 �����
if not exist "%SystemRoot%\system32\config\pass" goto BUG3
if not exist "%SystemRoot%\system32\md5.exe" goto BUG3
pause>nul
goto exit

:BUG2
echo.
echo   ���� Ewf 2.0 ϵͳ�������ע��������������𻵣����������°�װ Ewf 2.0 �����
del /f /q /a Filter.com >nul 2>nul
if not exist "%SystemRoot%\system32\config\pass" goto BUG3
if not exist "%SystemRoot%\system32\md5.exe" goto BUG3
pause>nul
goto exit

:BUG3
echo.
echo   ��⵽���� Ewf 2.0 ������֤�𻵣��޷����й�������������°�װ�������
pause>nul
goto exit

:AAA1
echo.
echo.
echo   ��ϲ�����б��ط����������� Ewf 2.0 ϵͳ������ϵͳ��ȫ�����ߡ�
del /f /q /a Filter.com >nul 2>nul
if not exist "%SystemRoot%\system32\config\pass" goto BUG3
if not exist "%SystemRoot%\system32\md5.exe" goto BUG3
pause>nul
goto exit

:AAA2
echo.
echo.
echo   ע�⣡���б��ط����� Ewf 2.0 ϵͳ�������ڹر�״̬�����ܴ��ڰ�ȫ������
del /f /q /a Filter.com >nul 2>nul
if not exist "%SystemRoot%\system32\config\pass" goto BUG3
if not exist "%SystemRoot%\system32\md5.exe" goto BUG3
pause>nul
goto exit

:exit
