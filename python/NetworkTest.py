from CommonUtils import Utils
from config import *

import time
import logging
import sys
import os
import re
import argparse
import socket
import webbrowser
import fileinput
import subprocess
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
    parser.add_argument("-s","--server", help="sets the server IP address", required=False)
    parser.add_argument("-c","--client", help="sets the client IP address", required=False)
    parser.add_argument("-i","--iterations", help="configures the number of iterations to run", required=False)
    args = parser.parse_args()

    # puts options/arguments into variables
    server_addr = args.server
    client_addr = args.client
    repeat = args.iterations
    email = args.email


    # gets email configuration from config.py and puts into variables
    server = EMAIL_SERVER
    port = EMAIL_PORT
    frm = EMAIL_FROM
    to = EMAIL_TO
    pwd = EMAIL_PASSWORD

    return [logfile, email, server, port, to, pwd, frm, server_addr, client_addr, repeat]

def Configure():
    print()
    print()
    print()
    print()
    print()
    print()
    print()
    print('{:^80}'.format("******************************"))
    print('{:^80}'.format("Welcome to Geoff's network test"))
    print('{:^80}'.format("******************************"))
    time.sleep(1.5)
    os.system("cls")

    print("Enter server IP address")
    print()
    print()
    server_addr = input("Enter IP address: ")
    try:
        socket.inet_aton(server_addr)
    except socket.error:
        logging.error("You must enter a valid IP address")
        raise SystemExit()
    else:
        os.system("cls")
        time.sleep(0.25)

    
    print("Enter client IP address")
    print()
    print()
    client_addr = input("Enter IP address: ")
    try:
        socket.inet_aton(client_addr)
    except socket.error:
        logging.error("You must enter a valid IP address")
        raise SystemExit()
    else:
        os.system("cls")
        time.sleep(0.25)

    
    print()
    repeat = input("Enter # of iterations you want to execute: ")
    try:
        int(repeat)
    except ValueError:
        logging.error("You must enter a valid number of iterations using numbers only")
        sys.exit()
    else:
        os.system("cls")
        time.sleep(0.25)

    print("Test will be run with the following settings")
    print("Server address = " + server_addr)
    print("Server address = " + client_addr)
    print("Iterations = " + str(repeat))
    print()

    answer = input("Do you want to start the test with these settings? Y/N: ")
    if answer == "y":
        return [server_addr, client_addr, repeat]
    if answer == "n":
        os.system("cls")
        Configure()

def NavigateHTTP(logfile, email, server, port, to, pwd, frm, repeat):

    f1 = os.path.realpath("network/http.txt")
    pybot = os.path.realpath("robotframework/pybot.bat " + f1)

    textfile = open(f1, 'r')
    filetext = textfile.read()
    textfile.close()
    match = re.findall("[A-Z]{2}\s[A-Z]{5}\s\s\d\s\s+[\d]{1,5}", filetext)
    match = "".join(match)    

    Utils().inplace_change(f1, match, "IN RANGE  0  " + repeat)
    # Runs http test
    #result = os.system("pybot ./network/http.txt")
    result = subprocess.check_output(pybot, shell=True)
    logging.info(result)

def Throughput(server_addr, client_addr):

    server_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -s -B " + server_addr
    client_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -c " + client_addr + " -B " + server_addr

    #sresult = subprocess.check_output("C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -s -B " + server_addr)
    #time.sleep(1)
    cresult = subprocess.check_output("C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -c " + client_addr + " -B " + server_addr)
    time.sleep(1)
    logging.info(sresult)
    logging.info(cresult)

    PROCNAME = 'iperf.exe'
    for proc in psutil.process_iter():
        try:
            if proc.name == PROCNAME:
                p = psutil.Process(proc.pid)
        except:
            pass


    








logfile, email, server, port, to, pwd, frm, server_addr, client_addr, repeat = Setup()
if server_addr == None or client_addr == None or repeat == None:
    server_addr, client_addr, repeat = Configure()
#NavigateHTTP(logfile, email, server, port, to, pwd, frm, repeat)
Throughput(server_addr, client_addr)