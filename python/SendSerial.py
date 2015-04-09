import serial
import time

txdata = ("U"*256)
cnt = 1
bd = 9600
bs = 8
par = "N"
sb = 1
xx = 0



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

while cnt < 51:

    ser1.write(txdata)
    #ser1.write(txdata)
##    ser1.close()
    #print "sending " + txdata


    #Read tx data
    rxdata = ser2.readline()
##    ser2.close()
    #print "received " + rxdata

                
    if txdata == rxdata:
        print "success " + str(cnt)
    else:
        print "fail " + str(cnt)

    cnt = cnt + 1

ser1.close()
ser2.close()
    



