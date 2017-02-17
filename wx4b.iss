#define AppName "微信网页版"
#define VersionInfoVersion "1.0.0.1"
#define APPEXE "wx4b.exe"
#define APPPUBLISHER "微信网页版"
#define VERSIONINFOCOPYRIGHT "微信网页版(www.accjs.org)"
#define VERSIONINFODESCRIPTION "微信网页版无障碍优化版本，作者： 杨永全"
#define VISITWEBSITE "访问网站"
#define FEEDBACK   "意见反馈"
#define SHORTCUTDESCRIPTION "微信网页版"
#define ISUPDATELOG "查看升级日志"
#define ISUPDATELOGFILE "升级日志.txt"
#define HELP "查看帮助"
#define INSTALLDOTNET "正在安装系统运行库（微软.Net Framework），请稍后。"
#define APPPUBLISHERURL "http://www.accjs.org/"
#define APPSUPPORTURL "http://www.accjs.org/"
#define APPUPDATESURL "http://www.accjs.org/"
#define FEEDBACKURL " http://www.accjs.org/forum-index-fid-4.htm"

[Setup]
AppName={#AppName}
AppVerName={#AppName} {#VersionInfoVersion}
VersionInfoVersion={#VersionInfoVersion}
AppPublisher={#APPPUBLISHER}
AppPublisherURL={#AppPublisherURL}
AppSupportURL={#AppSupportURL}
AppUpdatesURL={#AppUpdatesURL}
VersionInfoCopyright={#VersionInfoCopyright}
VersionInfoDescription={#VersionInfoDescription}
PrivilegesRequired=admin
DefaultDirName={ini:{src}\update.ini,settings,path|{pf}\wx4b}
DefaultGroupName={#APPPUBLISHER}
DisableProgramGroupPage=yes
DisableDirPage=yes
DisableReadyPage=yes
;UninstallFilesDir={app}
;Uninstallable = no
closeapplications=no
UsePreviousAppDir=no
OutputBaseFilename=wx4b_setup
Compression=lzma
SolidCompression=yes
;Appid={#APPGUID}

[Languages]
Name: chinesesimp; MessagesFile: compiler:Default.isl


[Messages]
SetupWindowTitle=%1 安装向导
FinishedHeadingLabel=安装完成
FinishedLabelNoIcons=祝您使用愉快。

[Dirs]
Name: "{app}"; Permissions: everyone-full

[Files]
Source: "distribution\*"; DestDir: "{app}"; Permissions: everyone-full; Flags: replacesameversion recursesubdirs createallsubdirs sortfilesbyextension restartreplace overwritereadonly

[Icons]
Name: "{group}\{#APPNAME}\{#APPNAME}"; Filename: "{app}\{#APPEXE}"; WorkingDir: "{app}"; Comment: "{#SHORTCUTDESCRIPTION}"; IconFilename: ""
Name: "{group}\{#APPNAME}\{#HELP}"; Filename: "{app}\使用说明.txt"
Name: "{group}\{#APPNAME}\{#VISITWEBSITE}"; Filename: "{#APPPUBLISHERURL}"
Name: "{group}\{#APPNAME}\{#FEEDBACK}"; Filename: {#FEEDBACKURL}
Name: "{group}\{#APPNAME}\{cm:UninstallProgram,{#APPNAME}}"; Filename: "{uninstallexe}"
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
