# Import the email modules we'll need
from email.MIMEMultipart import MIMEMultipart
from email.MIMEText import MIMEText

try:

    fromaddr="geoff.guenther@powerbyproxi.com"
    toaddr="geoff.guenther@powerbyproxi.com"
    msg=MIMEMultipart()
    msg['From']=fromaddr
    msg['To']=toaddr
    msg['Subject']="Python email"

    body="Python test email"
    msg.attach(MIMEText(body,'plain'))


    # Import smtplib for the actual sending function
    import smtplib

    server = smtplib.SMTP('smtp.gmail.com:587')
    server.ehlo()
    server.starttls()
    server.ehlo()
    server.login("geoff.guenther@powerbyproxi.com","Gunner2015")
    text = msg.as_string()
    server.sendmail(fromaddr,toaddr,text)
    print "successfully sent email to " + toaddr

except:
    print "failed to send email to " + toaddr
