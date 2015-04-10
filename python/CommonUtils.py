class Utils(object):

        def MsgBox(self, message, title, type):

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
                ret = msgbox(None, message, title, type)

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

        def SendEmail(self, server, port, fromaddr, toaddr, pwd, sub, body,):

                # Import the email modules we'll need
                from email.MIMEMultipart import MIMEMultipart
                from email.MIMEText import MIMEText

                try:

                    msg=MIMEMultipart()
                    msg['From']=fromaddr
                    msg['To']=toaddr
                    msg['Subject']=sub

                    #body=body
                    msg.attach(MIMEText(body,'plain'))


                    # Import smtplib for the actual sending function
                    import smtplib

                    server = smtplib.SMTP(server + ":" + port)
                    server.ehlo()
                    server.starttls()
                    server.ehlo()
                    server.login(fromaddr,pwd)
                    text = msg.as_string()
                    server.sendmail(fromaddr,toaddr,text)
                    print "successfully sent email to " + toaddr

                except:
                    print "failed to send email to " + toaddr



