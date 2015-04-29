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
import psutil
from argparse import RawTextHelpFormatter


def Setup():
    # gets current date/time
    now = Utils().datetimenow(1)

    # specifies logfile name
    logfile = "C:/Temp/Bandwidth_Test_" + now + ".log"

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


def Bandwidth(server_addr, client_addr, iterations, logfile):

    from subprocess import Popen
    
    PROCNAME = "iperf.exe"
    port = "22940"

    a = 0

    while a < int(iterations):

        server_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -s -P 1 -B " + server_addr + " -p " + str(port)
        client_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -t 0.1 -c " + server_addr + " -B " + client_addr + " -p " + str(port)

        Utils().run_iperf(server_cmd, client_cmd, port)


        #server_result = Utils().run_program

        #commands = [server_cmd, client_cmd]


    # kills any left over iperf processes running on the system
    Utils().kill_process(PROCNAME)

    a = a + 1
    port = int(port) + 1
    logging.info("Iteration # " + str(a))


logfile, email, server, port, to, pwd, frm, server_addr, client_addr, repeat = Setup()
if server_addr == None or client_addr == None or repeat == None:
    server_addr, client_addr, repeat = Configure()
Bandwidth(server_addr, client_addr, repeat, logfile)