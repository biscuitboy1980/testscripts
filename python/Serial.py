from CommonUtils import Utils
from config import *

import time
import re
import operator 
import logging
import sys
import os
import json
import argparse
from argparse import RawTextHelpFormatter


def Setup():
    # gets current date/time
    now = Utils().datetimenow(1)

    # specifies logfile name
    logfile = "C:/Temp/SerialTest_" + now + ".log"

    # checks to see if logfile directory exists and creates it if not
    dir = os.path.dirname(logfile)
    if not os.path.exists(dir):
        os.makedirs(dir)

    # creates logfile
    Utils().Logger(logfile, 1)

    # defines options/arguments
    parser = argparse.ArgumentParser(description="Serial Test Options")
    parser.add_argument("-e","--email", help="sends an email using the parameters in config.py", action="store_true", required=False)
    parser.add_argument("-t","--transmit", help="configures the transmit COM port", required=False)
    parser.add_argument("-r","--receive", help="configures the receive COM port", required=False)
    parser.add_argument("-b","--baud", help="configures the baud rate", required=False)
    parser.add_argument("-i","--iterations", help="configures the number of iterations to run", required=False)
    args = parser.parse_args()

    # puts options/arguments into variables
    txcom = args.transmit
    rxcom = args.receive
    baud = args.baud
    repeat = args.iterations
    email = args.email


    # gets email configuration from config.py and puts into variables
    server = EMAIL_SERVER
    port = EMAIL_PORT
    frm = EMAIL_FROM
    to = EMAIL_TO
    pwd = EMAIL_PASSWORD

    return [logfile, email, server, port, to, pwd, frm, txcom, rxcom, baud, repeat]

# gets serial ports on system and puts in dictionary and list
def GetPorts():
        
    import serial.tools.list_ports

    # gets configured serial ports of the system
    coms = (list(serial.tools.list_ports.comports()))
    coms = json.dumps(coms)

    # looks for all items inside () with 3 upper case alpha characters followed by at least 1 number character and sorts and puts in dictionary
    coms = re.findall ( '\(([A-Z]{3}[\d]{1,2})\)', coms, re.DOTALL)
    coms = Utils().natural_sort(coms)
    comsdict = dict(enumerate(line.strip() for line in coms))
    return [coms, comsdict]

def Configure(coms, comsdict):
    print()
    print()
    print()
    print()
    print()
    print()
    print()
    print('{:^80}'.format("******************************"))
    print('{:^80}'.format("Welcome to Geoff's serial test"))
    print('{:^80}'.format("******************************"))
    time.sleep(1.5)
    os.system("cls")

    print("Which COM port is your transmit port?")
    print()
    num = 0
    for e in coms:
        num = num + 1
        print(str(num) + ". " + e)
    print()
    answer = input("Which COM port is your transmit port: ")
    try:
        answer = int(answer) - 1
    except ValueError:
        logging.error("You must enter one of the numbers displayed as an option")
    else:
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
    print()
    num = 0
    for e in coms:
        num = num + 1
        print(str(num) + ". " + e)
    print()
    answer = input("Make your choice: ")
    try:
        answer = int(answer) - 1
    except ValueError:
        logging.error("You must enter one of the numbers displayed as an option")
    else:
        answer = comsdict.get(answer)
        rxcomname = answer
        answer = re.sub("\D", "", answer)
        rxcom = int(answer)-1
        os.system("cls")
        time.sleep(0.25)

    print()
    rates = [2400, 4800, 9600, 19200, 38400, 56700, 115200]
    ratesdict = dict(enumerate(rates))
    num = 0
    for e in rates:
        num = num + 1
        print(str(num) + ". " + str(e))
    print()
    answer = input("Enter the baud rate: ")
    try:
        answer = int(answer) - 1
    except ValueError:
        logging.error("You must enter one of the numbers displayed as an option")
    else:
        answer = ratesdict.get(answer)
        baud = answer
        os.system("cls")
        time.sleep(0.25)
    print()

    repeat = input("Enter # of iterations you want to execute: ")
    try:
        int(repeat)
    except ValueError:
        logging.error("You must enter a valid number of iterations using numbers only")
    else:
        os.system("cls")
        time.sleep(0.25)

    print("Test will be run with the following settings")
    print("Transmit port = " + txcomname)
    print("Receive port = " + rxcomname)
    print("Baud Rate = " + str(baud))
    print("Iterations = " + str(repeat))
    print()

    answer = input("Do you want to start the test with these settings? Y/N: ")
    if answer == "y":
        return [txcom, rxcom, baud, repeat]
    if answer == "n":
        os.system("cls")
        Configure()

def StartTest(logfile, email, server, port, to, pwd, frm):

    passed, failed, iterations = Utils().SendSerial(int(txcom), int(rxcom), "U"*256, int(repeat), int(baud))
    
    if passed == 0:
        logging.warn("All tests failed")
        if email == True:
            Utils().SendEmail(server, port, frm, to, pwd,"Serial Test Results", "All tests failed", logfile)
        result = Utils().MsgBox("All tests failed", "Failure", 1, 4)
        if result == 10:
            SerialTest()
        else:
            Utils().openFile(logfile)
    elif failed == 0:
        logging.info("All tests passed")
        if email == True:
            Utils().SendEmail(server, port, frm, to, pwd, "Serial Test Results", "All tests passed", logfile)
        result = Utils().MsgBox("All tests passed", "Passed", 0, 3)
        Utils().openFile(logfile)
    else:
        num = Utils().Percentage(passed,iterations)
        logging.warn(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)")
        if email == True:
            Utils().SendEmail(server, port, frm, to, pwd, "Serial Test Results", num + "% of tests passed", logfile)
        result = Utils().MsgBox(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)", "Results", 5, 1)
        if result == 4:
            SerialTest()
        else:
            Utils().openFile(logfile)

logfile, email, server, port, to, pwd, frm, txcom, rxcom, baud, repeat = Setup()
coms, comsdict = GetPorts()

# checks to see if values were supplied as command line parameters
if txcom == None or rxcom == None or baud == None or repeat == None: 
    txcom, rxcom, baud, repeat = Configure(coms, comsdict)

StartTest(logfile, email, server, port, to, pwd, frm)