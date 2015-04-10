import serial
import time

#Define COM Port Settings/Data

txdata = ("U"*256)
cnt = 1
bd = 38400
bs = 8
par = "N"
sb = 1
xx = 0

print "*****Start*****"

#Configure TX COM Port
ser1 = serial.Serial(4, timeout=1)
ser1.baudrate = bd
ser1.bytesize = bs
ser1.parity = par
ser1.stopbits = sb
ser1.xonxoff = xx
print ser1    

#Configure RX COM Port

ser2 = serial.Serial(5, timeout=1)
ser2.baudrate = bd
ser2.bytesize = bs
ser2.parity = par
ser2.stopbits = sb
ser2.xonxoff = xx
print ser2


#Loop TX/RX of test data

while cnt < 10:

    #Send tx data
    ser1.write(txdata)
    #print "sending " + txdata


    #Read tx data
    rxdata = ser2.readline()
    #print "received " + rxdata

                
    if txdata == rxdata:
        print "success " + str(cnt)
    else:
        print "fail " + str(cnt)

    cnt = cnt + 1

#Close TX/RX COM Ports

ser1.close()
ser2.close()
print "*****Finish*****"
