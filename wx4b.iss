#define AppId "wx4b.accjs.org"
#define AppName "微信网页版"
#define AppVersion "1.0.0.5"
#define AppVerName "微信网页版 1.0"
#define APPEXE "wx4b.exe"
#define AppPublisher "微信网页版"
#define AppPublisherURL "http://accjs.org/"
#define AppSupportURL "http://accjs.org/"
#define AppUpdatesURL "http://accjs.org/"
#define AppSupportPhone ""
#define AppReadmeFile ""
#define AppContact "http://accjs.org/"
#define AppComments "微信网页版无障碍优化版本，作者： 杨永全"
#define AppCopyright "http://accjs.org/"
#define VISITWEBSITE "访问网站"
#define FEEDBACK   "意见反馈"
#define SHORTCUTDESCRIPTION "微信网页版"
#define ISUPDATELOG "查看升级日志"
#define ISUPDATELOGFILE "升级日志.txt"
#define HELP "查看帮助"
#define FEEDBACKURL " http://www.accjs.org/forum-index-fid-4.htm"


[setup]
AppId={#AppId}
AppName={#AppName}
AppVersion={#AppVersion}
AppVerName={#AppVerName}
AppPublisher={#AppPublisher}
AppPublisherURL={#AppPublisherURL}
AppSupportURL={#AppSupportURL}
AppUpdatesURL={#AppUpdatesURL}
AppSupportPhone={#AppSupportPhone}
AppReadmeFile={#AppReadmeFile}
AppContact={#AppContact}
AppComments={#AppComments}
AppCopyright={#AppCopyright}
VersionInfoProductName={#AppName}
VersionInfoProductVersion={#AppVersion}
VersionInfoProductTextVersion={#AppVersion}
VersionInfoVersion={#AppVersion}
VersionInfoTextVersion={#AppVersion}
VersionInfoDescription={#AppComments}
VersionInfoCopyright={#AppCopyright}
VersionInfoCompany={#AppPublisher}
DefaultDirName={pf}\wx4b
DefaultGroupName={#AppPublisher}
;DisableDirPage=yes
;DisableFinishedPage=yes
;DisableProgramGroupPage=yes
;DisableReadyMemo=yes
;DisableReadyPage=yes
;DisableStartupPrompt=yes
;DisableWelcomePage=yes
PrivilegesRequired=admin
CloseApplications=no
UsePreviousAppDir=no
Uninstallable=yes
UninstallFilesDir={app}
OutputDir=output
OutputBaseFilename=wx4b_setup
;SourceDir=sources
;setupiconfile=icon.ICO
;LicenseFile
;infoBeforeFile = sources\licence.txt
RestartIfNeededByRun=no
ShowLanguageDialog=auto
Compression=lzma
SolidCompression=yes


[Languages]
Name: chinesesimp; MessagesFile: compiler:Default.isl


[Messages]
SetupWindowTitle=%1 安装向导
FinishedHeadingLabel=安装完成
FinishedLabelNoIcons=祝您使用愉快。

[Dirs]
Name: "{app}"; Permissions: everyone-full

[Files]
Source: "distribution\*"; DestDir: "{app}"; Permissions: everyone-full; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension restartreplace overwritereadonly

[Icons]
Name: "{group}\{#APPNAME}"; Filename: "{app}\{#APPEXE}"; WorkingDir: "{app}"; Comment: "{#SHORTCUTDESCRIPTION}"; IconFilename: ""
Name: "{group}\{#HELP}"; Filename: "{app}\使用说明.txt"
Name: "{group}\{#VISITWEBSITE}"; Filename: "{#APPPUBLISHERURL}"
Name: "{group}\{#FEEDBACK}"; Filename: {#FEEDBACKURL}
Name: "{group}\{cm:UninstallProgram,{#APPNAME}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#APPNAME}"; Filename: "{app}\{#APPEXE}"; WorkingDir: "{app}"; Comment: "{#SHORTCUTDESCRIPTION}"; IconFilename: ""

[Run]
  FileName: "{app}\{#APPEXE}"; Description: "立即开始使用"; Flags: postinstall
  FileName: "{app}\使用说明.txt"; Description: "查看使用说明"; flags: shellexec postinstall



[code]
const
WM_LBUTTONDOWN = 513;
WM_LBUTTONUP = 514;

procedure InitializeWizard();
begin
//PostMessage(WizardForm.NextButton.Handle,WM_LBUTTONDOWN,0,0);
//PostMessage(WizardForm.NextButton.Handle,WM_LBUTTONUP,0,0);
end;

// click the cancel button
procedure CancelButtonClick ( CurPageID : Integer; var Cancel, Confirm: Boolean);
begin
Confirm := False;
end;

//hide the nextbutton
procedure CurPageChanged(CurPageID: Integer);
begin
 WizardForm.BackButton.Hide;
end;
