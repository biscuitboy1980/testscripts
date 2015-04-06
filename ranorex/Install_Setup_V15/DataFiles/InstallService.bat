@echo off
reg.exe add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce /v PostRebootInstall  /t REG_SZ /d "path"