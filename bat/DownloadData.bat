@SET IPorHostname=10.10.10.10
@SET /p GunName=[Folder name to create]
@SET Password=9ot@mmo?
@SET destdir=C:/Users/%USERNAME%/Desktop/ScopeMedia/%GunName%
@if not exist %destdir% Goto NoDir
@echo "%destdir% already exists.  Delete or rename this folder and restart this script"
@pause
@Exit /B
:NoDir
@mkdir "%destdir%"
@mkdir "%destdir%/media"
@mkdir "%destdir%/blackbox"
@if exist %destdir% echo "%destdir% created"
@if exist "C:\apps\PuTTY" SET PuttyDir="C:\apps\PuTTY\
@if exist "C:\Program Files (x86)\PuTTY" SET PuttyDir="C:\Program Files (x86)\PuTTy\
@if exist "C:\Program Files\Putty" SET PuttyDir="C:\Program Files\PuTTy\
@%PuTTydir%pscp.exe" -pw %Password% -scp -r "\\tpfile1\development\QA\scripts\dates" root@%IPorHostname%:/data/
@%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% cd /data;"hwconfig > hwconfig.txt"
@%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% cd /data;chmod +x dates;./dates
@%PuTTydir%pscp.exe" -pw %Password% -scp -r root@%IPorHostname%:/data/hwconfig.txt c:/Users/%USERNAME%/Desktop/ScopeMedia/%GunName%
@%PuTTydir%pscp.exe" -pw %Password% -scp -r root@%IPorHostname%:/data/dates.txt c:/Users/%USERNAME%/Desktop/ScopeMedia/%GunName%
@%PuTTydir%pscp.exe" -pw %Password% -scp -r root@%IPorHostname%:/data/media c:/Users/%USERNAME%/Desktop/ScopeMedia/%GunName%
@%PuTTydir%pscp.exe" -pw %Password% -scp -r root@%IPorHostname%:/data/blackbox c:/Users/%USERNAME%/Desktop/ScopeMedia/%GunName%
@%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% cd /data;rm hwconfig.txt;rm dates.txt;rm dates
:@xcopy /e "%destdir%\media\*" "%destdir%\media\"
:@xcopy /e "%destdir%\blackbox\*" "%destdir%blackbox\"
:@rmdir /s /q "%destdir%\media
:@rmdir /s /q "%destdir%\blackbox