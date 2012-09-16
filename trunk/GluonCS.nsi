; Script generated by the HM NIS Edit Script Wizard.

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Gluon Control Station"
!define PRODUCT_VERSION "0.8 BETA 5"
!define PRODUCT_PUBLISHER "Gluonpilot"
!define PRODUCT_WEB_SITE "http://www.gluonpilot.com"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\GluonCS.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

; MUI 1.67 compatible ------
!include "MUI.nsh"

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!define MUI_FINISHPAGE_RUN "$INSTDIR\GluonCS.exe"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Setup.exe"
InstallDir "$PROGRAMFILES\Gluon Control Station ${PRODUCT_VERSION}"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails show
ShowUnInstDetails show

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite try
  SetOutPath "$INSTDIR\nl"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\nl\Configuration.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\nl\GluonCS.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\nl\Gluonpilot.resources.dll"
  SetOutPath "$INSTDIR\vi"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\vi\Configuration.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\vi\GluonCS.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\vi\Gluonpilot.resources.dll"
  SetOutPath "$INSTDIR\de"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\de\Configuration.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\de\GluonCS.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\de\Gluonpilot.resources.dll"
  SetOutPath "$INSTDIR\Documentation\de"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\block.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\circle.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\climb.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\emptycmd.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\flareto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\flyto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\flyto.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\fromto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\fromto.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\glideto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\goto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\if.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\de\until.html"
  SetOutPath "$INSTDIR\Documentation\en"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\block.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\circle.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\climb.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\emptycmd.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\flareto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\flyto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\flyto.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\fromto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\fromto.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\glideto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\goto.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\if.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\setbatteryalarm.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\setflightplanswitch.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\loitercircle.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\until.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\servoset.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\servotrigger.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\setloiterposition.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\call.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\return.html"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Documentation\en\circleto.html"
  SetOutPath "$INSTDIR\ds30loader"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\ds30loader\devices.xml"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\ds30loader\ds30LoaderConsole.exe"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\en\GluonCS.resources.dll"
  SetOutPath "$INSTDIR\Models\Easystar"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Easystar\easystar.jpg"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Easystar\easystar.x"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Easystar\texture.jpg"
  SetOutPath "$INSTDIR\Models\Funjet"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Funjet\funjet.jpg"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Funjet\funjet.x"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Funjet\texture.jpg"
  SetOutPath "$INSTDIR\Models\Reaper"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Reaper\Missile01.jpg"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Reaper\Missile02.jpg"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Reaper\MQ-9 Reaper.x"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Reaper\Sketchy_Crosshatch_Wavy.jpg"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Models\Reaper\Texture.jpg"
  SetOutPath "$INSTDIR\NavigationBlocks"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\NavigationBlocks\auto-land.gnf"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\NavigationBlocks\loiter.gnf"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\NavigationBlocks\standby.gnf"
  SetOutPath "$INSTDIR\nl"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\nl\Configuration.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\nl\GluonCS.resources.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\nl\Gluonpilot.resources.dll"
  SetOutPath "$INSTDIR\Resources"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\marker.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\marker_empty.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\marker_empty_gray.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\marker_empty_red.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\marker_empty_white.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\marker_empty_yellow.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\surveyimage.png"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Resources\windvane.png"
  SetOverwrite ifnewer
  SetOutPath "$INSTDIR"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\ZedGraph.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\System.Data.SQLite.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\SmartThreadPool.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\PredatorE.dae"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\OutputProtocol.xml"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\networklink.kml"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Kml.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\InputProtocol.xml"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Graph.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\GMap.NET.WindowsForms.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\GMap.NET.Core.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Gluonpilot.exe"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\GluonCS.vshost.exe.manifest"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\GluonCS.vshost.exe"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\GluonCS.exe"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\GluonCS.exe.config"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\GCS.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\FlightgearCommunication.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\D3DControls.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Configuration.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Communication.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Common.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\BSE.Windows.Forms.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\ArtificialHorizon.dll"
  File "C:\Users\Tom\Documents\Gluonpilot\SVN gluoncs\GluonCS\bin\Release\Artificial3DHorizon.dll"


  CreateDirectory "$SMPROGRAMS\Gluon Control Station ${PRODUCT_VERSION}"
  CreateShortCut "$SMPROGRAMS\Gluon Control Station ${PRODUCT_VERSION}\Gluon Control Station ${PRODUCT_VERSION}.lnk" "$INSTDIR\GluonCS.exe"
  CreateShortCut "$DESKTOP\Gluon Control Station ${PRODUCT_VERSION}.lnk" "$INSTDIR\GluonCS.exe"

SectionEnd

Section -AdditionalIcons
  WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  CreateShortCut "$SMPROGRAMS\Gluon Control Station ${PRODUCT_VERSION}\Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
  CreateShortCut "$SMPROGRAMS\Gluon Control Station ${PRODUCT_VERSION}\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\GluonCS.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\GluonCS.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer."
FunctionEnd

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  Abort
FunctionEnd

Section Uninstall
  Delete "$INSTDIR\${PRODUCT_NAME}.url"
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\Artificial3DHorizon.dll"
  Delete "$INSTDIR\ArtificialHorizon.dll"
  Delete "$INSTDIR\BSE.Windows.Forms.dll"
  Delete "$INSTDIR\Common.dll"
  Delete "$INSTDIR\Communication.dll"
  Delete "$INSTDIR\Configuration.dll"
  Delete "$INSTDIR\D3DControls.dll"
  Delete "$INSTDIR\FlightgearCommunication.dll"
  Delete "$INSTDIR\GCS.dll"
  Delete "$INSTDIR\GluonCS.exe"
  Delete "$INSTDIR\GluonCS.vshost.exe"
  Delete "$INSTDIR\GluonCS.vshost.exe.manifest"
  Delete "$INSTDIR\Gluonpilot.exe"
  Delete "$INSTDIR\GMap.NET.Core.dll"
  Delete "$INSTDIR\GMap.NET.WindowsForms.dll"
  Delete "$INSTDIR\Graph.dll"
  Delete "$INSTDIR\InputProtocol.xml"
  Delete "$INSTDIR\Kml.dll"
  Delete "$INSTDIR\networklink.kml"
  Delete "$INSTDIR\OutputProtocol.xml"
  Delete "$INSTDIR\PredatorE.dae"
  Delete "$INSTDIR\SmartThreadPool.dll"
  Delete "$INSTDIR\System.Data.SQLite.dll"
  Delete "$INSTDIR\ZedGraph.dll"
  Delete "$INSTDIR\windvane.png"
  Delete "$INSTDIR\surveyimage.png"
  Delete "$INSTDIR\marker_empty_yellow.png"
  Delete "$INSTDIR\marker_empty_white.png"
  Delete "$INSTDIR\marker_empty_red.png"
  Delete "$INSTDIR\marker_empty_gray.png"
  Delete "$INSTDIR\marker_empty.png"
  Delete "$INSTDIR\marker.png"
  Delete "$INSTDIR\Settings.settings"
  Delete "$INSTDIR\Settings.Designer.cs"
  Delete "$INSTDIR\Gluonpilot.resources.dll"
  Delete "$INSTDIR\GluonCS.resources.dll"
  Delete "$INSTDIR\Configuration.resources.dll"
  Delete "$INSTDIR\standby.gnf"
  Delete "$INSTDIR\loiter.gnf"
  Delete "$INSTDIR\auto-land.gnf"
  Delete "$INSTDIR\Reaper\Texture.jpg"
  Delete "$INSTDIR\Reaper\Sketchy_Crosshatch_Wavy.jpg"
  Delete "$INSTDIR\Reaper\MQ-9 Reaper.x"
  Delete "$INSTDIR\Reaper\Missile02.jpg"
  Delete "$INSTDIR\Reaper\Missile01.jpg"
  Delete "$INSTDIR\Funjet\texture.jpg"
  Delete "$INSTDIR\Funjet\funjet.x"
  Delete "$INSTDIR\Funjet\funjet.jpg"
  Delete "$INSTDIR\Easystar\texture.jpg"
  Delete "$INSTDIR\Easystar\easystar.x"
  Delete "$INSTDIR\Easystar\easystar.jpg"
  Delete "$INSTDIR\GluonCS.resources.dll"
  Delete "$INSTDIR\ds30LoaderConsole.exe"
  Delete "$INSTDIR\devices.xml"
  Delete "$INSTDIR\en\until.html"
  Delete "$INSTDIR\en\setbatteryalarm.html"
  Delete "$INSTDIR\en\setflightplanswitch.html"
  Delete "$INSTDIR\en\if.html"
  Delete "$INSTDIR\en\goto.html"
  Delete "$INSTDIR\en\glideto.html"
  Delete "$INSTDIR\en\fromto.png"
  Delete "$INSTDIR\en\fromto.html"
  Delete "$INSTDIR\en\flyto.png"
  Delete "$INSTDIR\en\flyto.html"
  Delete "$INSTDIR\en\flareto.html"
  Delete "$INSTDIR\en\emptycmd.html"
  Delete "$INSTDIR\en\climb.html"
  Delete "$INSTDIR\en\circle.html"
  Delete "$INSTDIR\en\block.html"
  Delete "$INSTDIR\en\loitercircle.html"
  Delete "$INSTDIR\en\servoset.html"
  Delete "$INSTDIR\en\servotrigger.html"
  Delete "$INSTDIR\en\setloiterposition.html"
  Delete "$INSTDIR\de\until.html"
  Delete "$INSTDIR\de\if.html"
  Delete "$INSTDIR\de\goto.html"
  Delete "$INSTDIR\de\glideto.html"
  Delete "$INSTDIR\de\fromto.png"
  Delete "$INSTDIR\de\fromto.html"
  Delete "$INSTDIR\de\flyto.png"
  Delete "$INSTDIR\de\flyto.html"
  Delete "$INSTDIR\de\flareto.html"
  Delete "$INSTDIR\de\emptycmd.html"
  Delete "$INSTDIR\de\climb.html"
  Delete "$INSTDIR\de\circle.html"
  Delete "$INSTDIR\de\block.html"
  Delete "$INSTDIR\de\Gluonpilot.resources.dll"
  Delete "$INSTDIR\de\GluonCS.resources.dll"
  Delete "$INSTDIR\de\Configuration.resources.dll"
  Delete "$INSTDIR\nl\Gluonpilot.resources.dll"
  Delete "$INSTDIR\nl\GluonCS.resources.dll"
  Delete "$INSTDIR\nl\Configuration.resources.dll"
  Delete "$INSTDIR\vi\Gluonpilot.resources.dll"
  Delete "$INSTDIR\vi\GluonCS.resources.dll"
  Delete "$INSTDIR\vi\Configuration.resources.dll"
  Delete "$INSTDIR\Gluonpilot.resources.dll"
  Delete "$INSTDIR\GluonCS.resources.dll"
  Delete "$INSTDIR\Configuration.resources.dll"

  Delete "$SMPROGRAMS\Gluon Control Station ${PRODUCT_VERSION}\Uninstall.lnk"
  Delete "$SMPROGRAMS\Gluon Control Station ${PRODUCT_VERSION}\Website.lnk"
  Delete "$DESKTOP\Gluon Control Station ${PRODUCT_VERSION}.lnk"
  Delete "$SMPROGRAMS\Gluon Control Station ${PRODUCT_VERSION}\Gluon Control Station ${PRODUCT_VERSION}.lnk"

  RMDir "$SMPROGRAMS\Gluon Control Station"
  RMDir "$INSTDIR\Reaper"
  RMDir "$INSTDIR\Funjet"
  RMDir "$INSTDIR\en"
  RMDir "$INSTDIR\Easystar"
  RMDir "$INSTDIR\de"
  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd
