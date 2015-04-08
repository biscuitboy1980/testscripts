import serial
import time

string1 = "test1"
string2 = "test2"
string3 = "test3"
string4 = "test4"
string5 = "test5"

ser = serial.Serial(0)  # open first serial port
print ser.name          # check which port was really used
ser.write(string1)      # write a string
print "sending " + string1
ser.close()       

time.sleep(1)           # sleeps for 1 seconds

ser = serial.Serial(0)  # open first serial port
ser.write(string2)      # write a string
print "sending " + string2
ser.close()       

time.sleep(1)           # sleeps for 1 seconds

ser = serial.Serial(0)  # open first serial port
ser.write(string3)      # write a string
print "sending " + string3
ser.close()

time.sleep(1)           # sleeps for 1 seconds

ser = serial.Serial(0)  # open first serial port
ser.write(string4)      # write a string
print "sending " + string4
ser.close()

time.sleep(1)           # sleeps for 1 seconds

ser = serial.Serial(0)  # open first serial port
ser.write(string5)      # write a string
print "sending " + string5
ser.close()       
