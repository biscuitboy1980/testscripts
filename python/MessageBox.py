import ctypes

#### Message Box #####

#### Types ####    
#### 0. OK ####
#### 1. OK/CANCEL ####
#### 2. ABORT/RETRY/IGNORE ####
#### 3. YES/NO/CANCEL ####
#### 4. YES/NO ####
#### 5. RETRY/CANCEL ####
#### 6. CANCEL/TRY AGAIN/CONTINUE ####



msgbox = ctypes.windll.user32.MessageBoxA
ret = msgbox(None, 'Press Yes to exit the demo.', 'Geoffs Python Demo', 6)

#### Return Values ####
#### 1. OK ####
#### 2. CANCEL ####
#### 3. ABORT ####
#### 4. RETRY ####
#### 5. IGNORE ####
#### 6. YES ####
#### 7. NO ####
#### 10. TRY AGAIN ####
#### 11. CONTINUE ####

