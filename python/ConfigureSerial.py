import serial


ser1 = serial.Serial()
print ser1
ser1.baudrate = 19200
ser1.port = 2
ser1.bytesize = 8
ser1.parity = "N"
ser1.stopbits = 1
ser1.xonxoff = 0
ser1.rtscts = 0
print ser1
ser1.open()
ser1.isOpen()
ser1.close()
ser1.isOpen()


ser2 = serial.Serial()
print ser2
ser2.baudrate = 19200
ser2.port = 3
ser2.bytesize = 8
ser2.parity = "N"
ser2.stopbits = 1
ser2.xonxoff = 0
ser2.rtscts = 0
print ser2
ser2.open()
ser2.isOpen()
ser2.close()
ser2.isOpen()
