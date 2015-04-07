import smtplib

try:

    fromaddr = 'biscuitboy1980@gmail.com'
    toaddrs  = 'gguenther29@gmail.com'
    sub = 'Test Message'
    msg = "\r\n".join([
      "From: biscuitboy1980@gmail.com",
      "To: gguenther29@gmail.com",
      "Subject: Test message",
      "",
      "Why, oh why"
      ])
    username = 'biscuitboy1980@gmail.com'
    password = 'gunner2013'
    
    server = smtplib.SMTP('smtp.gmail.com:587')
    server.ehlo()
    server.starttls()
    server.login(username,password)
    server.sendmail(fromaddr, toaddrs, msg)  
    server.close()
    print "successfully sent the mail to " + toaddrs

except:
    print "failed to send mail to " + toaddrs



