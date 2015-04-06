@SET IPorHostname=192.168.1.1
@SET Password=9ot@mmo?
@SET /p Range=[Set the range for this test]
@if exist "C:\apps\PuTTY" SET PuttyDir="C:\apps\PuTTY\
@if exist "C:\Program Files (x86)\PuTTY" SET PuttyDir="C:\Program Files (x86)\PuTTy\
@if exist "C:\Program Files\Putty" SET PuttyDir="C:\Program Files\PuTTy\
::%PuTTydir%pscp.exe" -pw %Password% -scp -r -unsafe "C:\Users\gguenther\Desktop" root@%IPorHostname%:/data/etc/network
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% gaz ball manrange %Range%
%PuTTydir%plink.exe" -pw %Password% root@%IPorHostname% gaz ball manrangeenable 1