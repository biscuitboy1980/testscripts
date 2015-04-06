SET IPorHostname=PGF6BE34E
@SET DestDir=XS1_OTM_250_Run_3
@SET /p EventNum=[Event Number to download]
@SET Password=9ot@mmo?
@SET eventdir=C:/Users/%USERNAME%/Desktop/%DestDir%/Event_%EventNum%
@Set bbdir=C:/Users/%USERNAME%/Desktop/%DestDir%/Event_%EventNum%/blackbox
@Set drdir=C:/Users/%USERNAME%/Desktop/%DestDir%/Event_%EventNum%/dataring
@Set mediadir=C:/Users/%USERNAME%/Desktop/%DestDir%/Event_%EventNum%/media
@if not exist %DestDir% Goto NoDir1
@echo "%DestDir% already exists.
@:NoDir1
@mkdir "%DestDir%"
@if not exist %bbdir% Goto NoDir2
@:NoDir2
@mkdir "%bbdir%"
@if not exist %drdir% Goto NoDir3
@:NoDir3
@mkdir "%drdir%"
@if not exist %mediadir% Goto NoDir4
@:NoDir4
@mkdir "%mediadir%"
@if exist "C:\apps\PuTTY" SET PuttyDir="C:\apps\PuTTY\
@if exist "C:\Program Files (x86)\PuTTY" SET PuttyDir="C:\Program Files (x86)\PuTTy\
@if exist "C:\Program Files\Putty" SET PuttyDir="C:\Program Files\PuTTy\
@%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% cd /data;"hwconfig > hwconfig.txt"
@%PuTTydir%pscp.exe" -pw %Password% -scp -r -unsafe root@%IPorHostname%:/data/blackbox/*%EventNum%* %EventDir%/blackbox
@%PuTTydir%pscp.exe" -pw %Password% -scp -r -unsafe root@%IPorHostname%:/data/dataring/*%EventNum%* %EventDir%/dataring
@%PuTTydir%pscp.exe" -pw %Password% -scp -r -unsafe root@%IPorHostname%:/data/media/*%EventNum%* %EventDir%/media
@%PuTTydir%pscp.exe" -pw %Password% -scp -r root@%IPorHostname%:/data/sysmon %DestDir%
@%PuTTydir%pscp.exe" -pw %Password% -scp -r root@%IPorHostname%:/data/etc %DestDir%
@%PuTTydir%pscp.exe" -pw %Password% -scp -r root@%IPorHostname%:/data/hwconfig.txt %DestDir%
@%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% cd /data;rm hwconfig.txt