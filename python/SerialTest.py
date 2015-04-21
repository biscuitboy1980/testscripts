from CommonUtils import Utils
#from GUI import SetupSerial

import Tkinter
from Tkinter import *
import time
import re
import operator 
import logging
import sys
import os
import json

#def option_changed(*args):
#        print "the user chose the value {}".format(GUI().txcom.get())

def Setup():

    now = Utils().datetimenow(1)
    logfile = "C:/Temp/testing/python_log_" + now + ".log"
    Utils().Logger(logfile)
    return logfile

def GetPorts():
        
    import serial.tools.list_ports

    coms = (list(serial.tools.list_ports.comports())) #gets configured serial ports on the system
    coms = json.dumps(coms)
    coms = re.findall ( '\(([A-Z]{3}[\d]{1,2})\)', coms, re.DOTALL) #looks for all items inside () with 3 upper case alpha characters and at least 1 number character
    #coms = sorted(coms)
    coms = Utils().natural_sort(coms)
    comsdict = dict(enumerate(line.strip() for line in coms)) #puts coms in a dictionary
    return [coms, comsdict]


def Configure(coms, comsdict):
    print
    print
    print
    print
    print
    print
    print
    print('{:^80}'.format("******************************"))
    print('{:^80}'.format("Welcome to Geoff's serial test"))
    print('{:^80}'.format("******************************"))
    time.sleep(1.5)
    os.system("cls")

    print("Which COM port is your transmit port?")
    print
    num = 0
    for e in coms:
        num = num + 1
        print str(num) + ". " + e
    print
    answer = raw_input("Make your choice: ")
    answer = int(answer) - 1
    comsdictkey = answer
    answer = comsdict.get(answer)
    txcomname = answer
    del comsdict[comsdictkey]
    coms.remove(answer)
    comsdict = dict(enumerate(line.strip() for line in coms)) #updates coms dictionary
    answer = re.sub("\D", "", answer)
    txcom = int(answer)-1
    os.system("cls")
    time.sleep(0.25)

    print("Which COM port is your receive port?")
    print
    num = 0
    for e in coms:
        num = num + 1
        print str(num) + ". " + e
    print
    answer = raw_input("Make your choice: ")
    answer = int(answer) - 1
    answer = comsdict.get(answer)
    rxcomname = answer
    answer = re.sub("\D", "", answer)
    rxcom = int(answer)-1
    os.system("cls")
    time.sleep(0.25)

    print
    baud = raw_input("Enter the baud rate: ")
    print
    os.system("cls")
    time.sleep(0.25)

    print
    repeat = raw_input("Enter # of iterations you want to execute: ")
    os.system("cls")
    time.sleep(0.25)

    print "Test will be run with the following settings"
    print "Transmit port = " + txcomname
    print "Receive port = " + rxcomname
    print "Baud Rate = " + str(baud)
    print "Iterations = " + str(repeat)
    print

    answer = raw_input("Do you want to start the test with these settings? Y/N: ")
    if answer == "y":
        return [txcom, rxcom, baud, repeat]
    if answer == "n":
        os.system("cls")
        Configure()

def StartTest(logfile):

    passed, failed, iterations = Utils().SendSerial(int(txcom), int(rxcom), "U"*256, int(repeat), int(baud))

    if passed == 0:
        logging.warn("All tests failed")
        Utils().SendEmail("smtp.gmail.com", "587", "geoff.guenther@powerbyproxi.com", "geoff.guenther@powerbyproxi.com", "Gunner2015", "Test Results", "All tests failed", logfile)
        result = Utils().MsgBox("All tests failed", "Failure", 1, 4)
        if result == 10:
            SerialTest()
        else:
            Utils().openFile(logfile)
    elif failed == 0:
        logging.info("All tests passed")
        Utils().SendEmail("smtp.gmail.com", "587", "geoff.guenther@powerbyproxi.com", "geoff.guenther@powerbyproxi.com", "Gunner2015", "Test Results", "All tests passed", logfile)
        result = Utils().MsgBox("All tests passed", "Passed", 0, 3)
        Utils().openFile(logfile)
    else:
        num = Utils().Percentage(passed,iterations)
        logging.warn(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)")
        Utils().SendEmail("smtp.gmail.com", "587", "geoff.guenther@powerbyproxi.com", "geoff.guenther@powerbyproxi.com", "Gunner2015", "Serial Test Results", num + "% of tests passed", logfile)
        result = Utils().MsgBox(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)", "Results", 5, 1)
        if result == 4:
            SerialTest()
        else:
            Utils().openFile(logfile)


logfile = Setup()
coms, comsdict = GetPorts()
txcom, rxcom, baud, repeat = Configure(coms, comsdict)
StartTest(logfile)