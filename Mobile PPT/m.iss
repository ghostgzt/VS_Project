; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

[Setup]
AppName=Mobile PPT
AppVerName=Fuck Q��
AppPublisher=Fuck Q��
AppPublisherURL=http://www.mcl1991.ys168.com/
AppSupportURL=http://www.mcl1991.ys168.com/
AppUpdatesURL=http://www.mcl1991.ys168.com/
DefaultDirName={pf}\Mobile PPT
DefaultGroupName=Mobile PPT
OutputDir=C:\Documents and Settings\Administrator\����
OutputBaseFilename=Mobile PPT Setup
SetupIconFile=F:\SKY\Mobile PPT\ppt.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\SKY\Mobile PPT\bin\Debug\Mobile PPT.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\SKY\Mobile PPT\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{group}\Mobile PPT"; Filename: "{app}\Mobile PPT.exe"
Name: "{commondesktop}\Mobile PPT"; Filename: "{app}\Mobile PPT.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Mobile PPT"; Filename: "{app}\Mobile PPT.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\Mobile PPT.exe"; Description: "{cm:LaunchProgram,Mobile PPT}"; Flags: nowait postinstall skipifsilent

