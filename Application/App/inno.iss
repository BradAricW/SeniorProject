; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "EdgeLook"
#define MyAppVersion "1.5"
#define MyAppPublisher "My Company, Inc."
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "EDGELook.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4F3D5C1E-C874-454C-87D0-1149DB5008D7}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\valer\Desktop\Application\App
OutputBaseFilename=mysetup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.MainForm.resources"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.Properties.Resources.resources"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.csproj.CopyComplete"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.csproj.CoreCompileInputs.cache"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.csproj.FileListAbsolute.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.csproj.GenerateResource.cache"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\valer\Desktop\Application\Release\EDGELook.csprojAssemblyReference.cache"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
