; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

[Setup]
AppName=EWF Protect System
AppVerName=EWF Protect System 1.5
AppPublisher=Fuck Q！
DefaultDirName={pf}\EWF Protect System
DefaultGroupName=EWF Protect System
OutputDir=F:\Desktop
OutputBaseFilename=setup
SetupIconFile=F:\My Documents\Icon\bear.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\SKY\EWF Protect System\EWF Protect System\bin\Debug\EWF Protect System.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\SKY\EWF Protect System\EWF Protect System\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{group}\EWF Protect System"; Filename: "{app}\EWF Protect System.exe"
Name: "{commondesktop}\EWF Protect System"; Filename: "{app}\EWF Protect System.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\EWF Protect System"; Filename: "{app}\EWF Protect System.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\EWF Protect System.exe"; Description: "{cm:LaunchProgram,EWF Protect System}"; Flags: nowait postinstall skipifsilent

