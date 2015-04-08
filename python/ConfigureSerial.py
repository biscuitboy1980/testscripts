import serial


ser = serial.Serial()
print ser
ser.baudrate = 19200
ser.port = 0
ser.bytesize = 8
ser.parity = "N"
ser.stopbits = 1
ser.xonxoff = 0
ser.rtscts = 0
print ser
ser.open()
ser.isOpen()
ser.close()
ser.isOpen()
