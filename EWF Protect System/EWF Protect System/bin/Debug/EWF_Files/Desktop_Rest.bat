��a
cls
@echo off
title �ָ�����ͼ�� �� ���أ���
color 1f
MODE con: COLS=80 LINES=30

:AAA1
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
if not exist "%SystemRoot%\system32\��������ͼ��\PECMD.EXE" goto CuoWu6
if not exist "%SystemRoot%\system32\drivers\ewf.sys" goto CuoWu6
if not exist "%SystemRoot%\system32\drivers\Filter.sys" goto CuoWu6
echo.
echo.  Σ�ղ������������أ�
echo.
echo.
echo.  1���ָ��������ϴα����״̬�����������е��ļ�����ʧ��
echo.
echo.  2���ر����������д򿪵��ļ����������еĳ���ת����������Ҫ�ļ����𴦡�
echo.
echo.
set AA=
set /p AA=  �� Y �ָ�   �� N �˳�   ��������س���ȷ�� 
if defined AA goto AAA2
if not defined AA goto AAA1

:AAA2
        if /i %AA% EQU Y  (goto AAA3
) else (if /i %AA% EQU N  (goto exit
) else (goto CuoWu2
)
)

:CuoWu2
echo.
echo.  �������벻��ȷ���ٴ����� Y �� N ��
pause>nul
goto AAA1

:CuoWu6
echo.
echo   ��⵽���� Ewf 2.0 ϵͳ���������ʧ�ļ������������°�װ Ewf 2.0 �����
pause>nul
goto exit

:AAA3
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
echo.  ����Ҫ�ָ�����...
echo.
md "D:\Temp" >nul 2>nul
md "D:\IE Temp" >nul 2>nul
md "D:\�ҵ�����" >nul 2>nul
md "D:\�ҵ��ĵ�" >nul 2>nul
attrib +h "D:\Temp"
attrib +h "D:\IE Temp"
attrib +h "D:\�ҵ�����"
cd /D "%SystemRoot%\system32\��������ͼ��"
PECMD.EXE FILE "D:\�ҵ�����\*"
PECMD.EXE FILE "%ALLUSERSPROFILE%\����\*"
PECMD.EXE FILE "D:\Temp\*"
PECMD.EXE FILE "%SystemRoot%\system32\��������ͼ��\����All Users�����ݷ�ʽ\*=>%ALLUSERSPROFILE%\����"
PECMD.EXE FILE "%SystemRoot%\system32\��������ͼ��\���浱ǰ�û������ݷ�ʽ\*=>D:\�ҵ�����\"

:exit