import SendKeys
import pywinauto

app = pywinauto.application.Application() #creates application
app.start_("calc.exe")  #starts calc application
time.sleep(1)
w_handle = pywinauto.findwindows.find_windows(title=u'Calculator', class_name='CalcFrame')[0] #Defines window
window = app.window_(handle=w_handle) #Defines window
window.Click()
ctrl = window['Button10']
ctrl.Click()
num1 = window.Window_(class_name='Static', ctrl_index=5).WindowText()
logging.info(str(num1))
ctrl = window['Button21']
ctrl.Click()
ctrl = window['Button14']
ctrl.Click()
num2 = window.Window_(class_name='Static', ctrl_index=5).WindowText()
logging.info(str(num2))
ctrl = window['Button28']
ctrl.Click()
actresult = window.Window_(class_name='Static', ctrl_index=5).WindowText()
logging.info("actual result = " + str(actresult))

expresult = int(num1) * int(num2)
logging.info("expected result = " + str(expresult))

if int(actresult) == int(expresult):
    logging.info("test pass " + num1 + " x " + num2 + " = " + str(expresult))
else:
    logging.info("test failed " + num1 + " x " + num2 + " = " + str(actresult) + ", expected result was " + str(expresult))

window.Close()

button = pywinauto.controls.HwndWrapper.ControlID()
print button