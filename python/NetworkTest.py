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
    logfile = "C:/Temp/NetworkTest_" + now + ".log"

    # checks to see if logfile directory exists and creates it if not
    dir = os.path.dirname(logfile)
    if not os.path.exists(dir):
        os.makedirs(dir)

    # creates logfile
    Utils().Logger(logfile)

    # defines options/arguments
    parser = argparse.ArgumentParser(description="Network Test Options")
    parser.add_argument("-e","--email", help="sends an email using the parameters in config.py", action="store_true", required=False)
    parser.add_argument("-a","--address", help="sets the IP address to send to", required=False)
    parser.add_argument("-i","--iterations", help="configures the number of iterations to run", required=False)
    args = parser.parse_args()

    # puts options/arguments into variables
    addr = args.address
    repeat = args.iterations
    email = args.email


    # gets email configuration from config.py and puts into variables
    server = EMAIL_SERVER
    port = EMAIL_PORT
    frm = EMAIL_FROM
    to = EMAIL_TO
    pwd = EMAIL_PASSWORD

    return [logfile, email, server, port, to, pwd, frm, addr, repeat]

# Creates socket connection
def CreateSocket():

    #create an INET, STREAMing socket
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    #now connect to the web server on port 80
    # - the normal http port
    s.connect(("www.google.com", 80))

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

    print("What IP address do you want to tx/rx data to?")
    print
    print
    answer = raw_input("Enter IP address: ")
    try:
        answer = int(answer) - 1
    except ValueError:
        logging.error("You must enter one of the numbers displayed as an option")
    else:
        addr = answer
        os.system("cls")
        time.sleep(0.25)

  
    print
    repeat = raw_input("Enter # of iterations you want to execute: ")
    try:
        int(repeat)
    except ValueError:
        logging.error("You must enter a valid number of iterations using numbers only")
    else:
        os.system("cls")
        time.sleep(0.25)

    print "Test will be run with the following settings"
    print "IP address = " + txcomname
    print "Iterations = " + str(repeat)
    print

    answer = raw_input("Do you want to start the test with these settings? Y/N: ")
    if answer == "y":
        return [addr, repeat]
    if answer == "n":
        os.system("cls")
        Configure()

#def StartTest(logfile, email, server, port, to, pwd, frm):

#    passed, failed, iterations = Utils().SendSerial(int(txcom), int(rxcom), "U"*256, int(repeat), int(baud))
    
#    if passed == 0:
#        logging.warn("All tests failed")
#        if email == True:
#            Utils().SendEmail(server, port, frm, to, pwd,"Test Results", "All tests failed", logfile)
#        result = Utils().MsgBox("All tests failed", "Failure", 1, 4)
#        if result == 10:
#            SerialTest()
#        else:
#            Utils().openFile(logfile)
#    elif failed == 0:
#        logging.info("All tests passed")
#        if email == True:
#            Utils().SendEmail(server, port, frm, to, pwd, "Test Results", "All tests passed", logfile)
#        result = Utils().MsgBox("All tests passed", "Passed", 0, 3)
#        Utils().openFile(logfile)
#    else:
#        num = Utils().Percentage(passed,iterations)
#        logging.warn(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)")
#        if email == True:
#            Utils().SendEmail(server, port, frm, to, pwd, "Serial Test Results", num + "% of tests passed", logfile)
#        result = Utils().MsgBox(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)", "Results", 5, 1)
#        if result == 4:
#            SerialTest()
#        else:
#            Utils().openFile(logfile)

logfile, email, server, port, to, pwd, frm, addr, repeat = Setup()
 = CreateSocket()
if addr == None or repeat == None:
    txcom, rxcom, baud, repeat = Configure(addr)
#StartTest(logfile, email, server, port, to, pwd, frm)