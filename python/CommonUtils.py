import logging


class Utils(object):

        def MsgBox(self, message, title, type, ico): #Messagebox function


                import ctypes

                #### Icons ####
                #### 1.  Exclaimation ####
                #### 2.  Question ####
                #### 3.  Info ####
                #### 4.  Stop ####

                if ico == 1:
                    ico = 0x30
                if ico == 2:
                    ico = 0x20
                if ico == 3:
                    ico = 0x40
                if ico == 4:
                    ico = 0x10

                #### Message Box #####

                #### Types ####
                #### 0.  OK ####
                #### 1.  OK/CANCEL ####
                #### 2.  ABORT/RETRY/IGNORE ####
                #### 3.  YES/NO/CANCEL ####
                #### 4.  YES/NO ####
                #### 5.  RETRY/CANCEL ####
                #### 6.  CANCEL/TRY AGAIN/CONTINUE ####

                msgbox = ctypes.windll.user32.MessageBoxW
                result = msgbox(None, message, title, type | ico) 

                #### Return Values ####
                #### 1.  OK ####
                #### 2.  Cancel ####
                #### 3.  Abort ####
                #### 4.  Retry ####
                #### 5.  Ignore ####
                #### 6.  Yes ####
                #### 7.  No ####
                #### 10.  Try Again ####
                #### 11.  Continue ####
                
                return result


        def SendEmail(self, server, port, fromaddr, toaddr, pwd, sub, body, attach):   #Send email function


                # Import the email modules we'll need
                from email.mime.multipart import MIMEMultipart
                from email.mime.text import MIMEText
                import smtplib

                try:

                    #To/From/Subject                   
                    msg = MIMEMultipart()
                    msg['From'] = fromaddr
                    msg['To'] = toaddr
                    msg['Subject'] = sub

                    #body=body
                    msg.attach(MIMEText(body,'plain'))

                    #Attachment
                    #filename = "C:/Temp/testing/python_log_20150416_124243.txt"
                    #f = file(filename)
                    #attachment = MIMEText(f.read())
                    #attachment.add_header('Content-Disposition', 'attachment', filename=filename)           
                    #msg.attach(attachment)

                    f = open(attach)
                    attachment = MIMEText(f.read())
                    attachment.add_header('Content-Disposition', 'attachment', filename=attach)           
                    msg.attach(attachment)

                    # Import smtplib for the actual sending function
                    server = smtplib.SMTP(server + ":" + port)
                    server.ehlo()
                    server.starttls()
                    server.ehlo()
                    server.login(fromaddr,pwd)
                    text = msg.as_string()
                    server.sendmail(fromaddr,toaddr,text)
                    logging.info("successfully sent email to " + toaddr)

                except ValueError:
                    logging.error("failed to send email to " + toaddr)
        
                    
        def SendSerial(self, txport, rxport, txdata, cycles, bd):   #Defines COM ports and sends data

                import serial    

                #Define COM Port Settings/Data

                cnt = 1
                bs = 8
                par = "N"
                sb = 1
                xx = 0
                passed = 0
                failed = 0 

                logging.info("***************")
                logging.info("*****Start*****")
                logging.info("***************")
               
                logging.info("Cycles set to " + str(cycles))

                #Configure TX COM Port
                
                ser1 = serial.Serial(txport, timeout=1)
                ser1.baudrate = bd
                ser1.bytesize = bs
                ser1.parity = par
                ser1.stopbits = sb
                ser1.xonxoff = xx
                logging.info("-----------------------------")
                logging.info("Transmit serial port settings")
                logging.info("-----------------------------")
                logging.info(ser1) 
                

                #Configure RX COM Port

                ser2 = serial.Serial(rxport, timeout=1)
                ser2.baudrate = bd
                ser2.bytesize = bs
                ser2.parity = par
                ser2.stopbits = sb
                ser2.xonxoff = xx
                logging.info("-----------------------------")
                logging.info("Receive serial port settings")
                logging.info("-----------------------------")
                logging.info(ser2)



                #Loop TX/RX of test data

                logging.info("*************************")
                logging.info("*****Starting cycles*****")
                logging.info("*************************")
                
                cycles = cycles + 1

                while cnt < cycles:

                    #Send tx data
                    ser1.write(txdata.encode())
                    #logging.info "sending " + txdata

                    import time

                    #Read tx data
                    rxdata = ser2.readline()
                    if rxdata != None:
                        rxdata = (bytes.decode(rxdata))
                    #logging.info "received " + rxdata

                
                    if txdata == rxdata:
                        logging.info("success " + str(cnt))
                        passed = passed + 1

                    else:
                        logging.warn("fail " + str(cnt))
                        failed = failed + 1

                    cnt = cnt + 1

                #Close TX/RX COM Ports

                ser1.close()
                ser2.close()
                
                logging.info("****************")
                logging.info("*****Finish*****")
                logging.info("****************") 
  
                #failed = failed + 1 #test code

                return [passed, failed, cycles]
           

        def Logger(self, fname):   #Defines logger settings

                import time

                logging.basicConfig(level=logging.DEBUG,
                    format='%(asctime)s %(name)-12s %(levelname)-8s %(message)s',
                    datefmt='%m-%d %H:%M',
                    filename=(fname),
                    filemode='w')

                # define a Handler which writes INFO messages or higher to the
                # sys.stderr

                console = logging.StreamHandler()
                console.setLevel(logging.INFO)

                # set a format which is simpler for console use
                #formatter = logging.Formatter('%(name)-12s: %(levelname)-8s
                #%(message)s')

                formatter = logging.Formatter('%(levelname)-8s %(message)s')

                # tell the handler to use this format

                console.setFormatter(formatter)

                # add the handler to the root logger

                logging.getLogger('').addHandler(console)


        def Percentage(self, part, whole): # Returns percentage with 2 digits
             num = 100 * float(part) / float(whole)
             num = "%.2f" % num
             return num


        def openFile(self, fname): # Opens file

            import os

            os.startfile(fname)


        def datetimenow(self, format): # Returns date/time # 1 returns without _,-,: removed, any other number returns with _,-,: 

            from datetime import datetime

            if format == 1:
                now = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
                now = now.replace (" ", "_")
                now = now.replace ("-", "")
                now = now.replace (":", "")
                return now
            else:
                now = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
                return now


        def natural_sort(self, items): # Performs a natural sort on items with letter and numbers (i.e. COM1, COM2, COM10)

            import re

            convert = lambda text: int(text) if text.isdigit() else text.lower() 
            alphanum_key = lambda key: [ convert(c) for c in re.split('([0-9]+)', key) ] 
            return sorted(items, key = alphanum_key)


        def inplace_change(self, filename, old_string, new_string):

            import time
            
            s=open(filename).read()
            if old_string in s:
                    s=s.replace(old_string, new_string)
                    f=open(filename, 'w')
                    f.write(s)
                    f.flush()
                    f.close()
            else:
                    print("No occurances of " + old_string + " found.").format(**locals())


        def kill_process(self, processname):

            import wmi

            c = wmi.WMI ()

            for process in c.Win32_Process (name="iperf.exe"):
              print(process.ProcessId, process.Name + " process killed")
              result = process.Terminate()


        def run_program(self, cmd, logfile):
            p = subprocess.Popen(cmd, shell=True, universal_newlines=True, stdout=logfile)
            return p


        def run_iperf(self, cmd1, cmd2, repeat):

            import time
            import subprocess
            from subprocess import Popen, PIPE, STDOUT

            cnt = 0
            port = 55600

            while cnt < int(repeat):

                if port > 56000:
                    port = 55000
                
                p1 = subprocess.Popen(cmd1 + str(port), stdout=subprocess.PIPE, stderr=STDOUT)
                p2 = subprocess.Popen(cmd2+ str(port), stdin=p1.stdout, stdout=PIPE, stderr=STDOUT)
                out = None
                out = p2.communicate()
                out = str(out).replace("(b", "").replace("\\n", "").replace(", None)", "").replace("-", "")
                logging.info(str(out).rstrip())
                port = int(port) + 1
                if out.find("connect failed:") != 1:
                    cnt = cnt + 1
                Utils().kill_process("iperf.exe")