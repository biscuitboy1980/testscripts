@SET IPorHostname=192.168.1.1
@SET Password=9ot@mmo?
@CHOICE /C:1234 /T 9999 /D 1 /M "Select gun type for this test: 1) LMT-762 2) DD-556 3) DD-300B 4) NEMO-300WM"+
@IF %ERRORLEVEL% EQU 1 GOTO LMT762
@IF %ERRORLEVEL% EQU 2 GOTO DD556
@IF %ERRORLEVEL% EQU 3 GOTO DD300B
@IF %ERRORLEVEL% EQU 4 GOTO NEMO300WM

:LMT762
@set Gun=LMT-762
@choice /c 12 /T 9999 /D 1 /M "Select Ammo for this test: A) OTM-175 B) TSX-168"
@IF %ERRORLEVEL% EQU 1 SET Ammo=OTM-175
@IF %ERRORLEVEL% EQU 2 SET Ammo=TSX-168
@GOTO Range

:DD556
@set Gun=DD-556
@choice /c 12 /T 9999 /D 1 /M "Select Ammo for this test: A) OTM-69 B) TSX-70"
@IF %ERRORLEVEL% EQU 1 SET Ammo=OTM-69
@IF %ERRORLEVEL% EQU 2 SET Ammo=TSX-70 
@GOTO Range

:DD300B
@set Gun=DD-300B
@choice /c 12 /T 9999 /D 1 /M "Select Ammo for this test: A) OTM-120 B) TAC-120"
@IF %ERRORLEVEL% EQU 1 SET Ammo=OTM-120
@IF %ERRORLEVEL% EQU 2 SET Ammo=TAC-120
@GOTO Range

:NEMO300WM
@set Gun=NEMO-300WM
@choice /c 12 /T 9999 /D 1 /M "Select Ammo for this test: A) OTM-220 B) LRX-190"
@IF %ERRORLEVEL% EQU 1 SET Ammo=OTM-220
@IF %ERRORLEVEL% EQU 2 SET Ammo=LRX-190
@GOTO Range


:Range
@SET /p Range=[Set the range for this test]
echo Seting selected values
@if exist "C:\apps\PuTTY" SET PuttyDir="C:\apps\PuTTY\
@if exist "C:\Program Files (x86)\PuTTY" SET PuttyDir="C:\Program Files (x86)\PuTTy\
@if exist "C:\Program Files\Putty" SET PuttyDir="C:\Program Files\PuTTy\
::%PuTTydir%pscp.exe" -pw %Password% -scp -r -unsafe "C:\Users\gguenther\Desktop" root@%IPorHostname%:/data/etc/network
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% "echo mode advanced | socat - unix:/tmp/gazelle"
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% "echo config unlock | socat - unix:/tmp/gazelle"
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% "echo ball gun %Gun% | socat - unix:/tmp/gazelle"
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% "echo config lock | socat - unix:/tmp/gazelle"
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% "echo ball ammo %Ammo% | socat - unix:/tmp/gazelle"
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% "echo ball manrange %Range% | socat - unix:/tmp/gazelle"
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% "echo ball manrangeenable 1 | socat - unix:/tmp/gazelle"

echo The following values were set %Gun% %Ammo% range %Range% yards