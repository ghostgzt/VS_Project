; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

[Setup]
AppName=Java Explorer
AppVerName=Fuck Q��
AppPublisher=GhostGzt
AppPublisherURL=http://www.mcl1991.ys168.com/
AppSupportURL=http://www.mcl1991.ys168.com/
AppUpdatesURL=http://www.mcl1991.ys168.com/
DefaultDirName={pf}\Java Explorer
DefaultGroupName=Java Explorer
InfoBeforeFile=C:\Documents and Settings\Administrator\����\Java Explorer(����).rtf
OutputDir=C:\Documents and Settings\Administrator\����
OutputBaseFilename=Java Explorer setup 4.80
SetupIconFile=F:\SKY\Jar\JAVA Explorer\JAVA Explorer\My-Documents.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Documents and Settings\Administrator\����\JE\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{group}\Java Explorer"; Filename: "{app}\Java Explorer.exe"
Name: "{group}\{cm:ProgramOnTheWeb,Java Explorer}"; Filename: "http://www.mcl1991.ys168.com/"
Name: "{commondesktop}\Java Explorer"; Filename: "{app}\Java Explorer.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Java Explorer"; Filename: "{app}\Java Explorer.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\Java Explorer.exe"; Description: "{cm:LaunchProgram,Java Explorer}"; Flags: nowait postinstall skipifsilent

