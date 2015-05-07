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
import csv
from statistics import mean
from argparse import RawTextHelpFormatter


# Must have iperf installed and in your path in order to run this program as is

def Setup():
    # gets current date/time
    now = Utils().datetimenow(1)

    # specifies logfile name
    logfile = "C:/Temp/Bandwidth_Test_" + now + ".csv"

    # checks to see if logfile directory exists and creates it if not
    dir = os.path.dirname(logfile)
    if not os.path.exists(dir):
        os.makedirs(dir)

    # creates logfile
    Utils().Logger(logfile, 2)
    logging.info("iteration,timestamp,source_address,source_port,destination_address,destination_port,ID,interval,transferred_bytes,bits_per_second")
    os.system("cls")

    # defines options/arguments
    parser = argparse.ArgumentParser(description="Network Throughput Test Options")
    parser.add_argument("-e","--email", help="sends an email using the parameters in config.py", action="store_true", required=False)
    parser.add_argument("-s","--server", help="sets the server IP address", required=False)
    parser.add_argument("-c","--client", help="sets the client IP address", required=False)
    parser.add_argument("-i","--iterations", help="configures the number of iterations to run", required=False)
    parser.add_argument("-t","--time", help="configures the time in seconds to transmit for", required=False)
    args = parser.parse_args()

    # puts options/arguments into variables
    server_addr = args.server
    client_addr = args.client
    repeat = args.iterations
    email = args.email
    txtime = args.time


    # gets email configuration from config.py and puts into variables
    server = EMAIL_SERVER
    port = EMAIL_PORT
    frm = EMAIL_FROM
    to = EMAIL_TO
    pwd = EMAIL_PASSWORD


    return [logfile, email, server, port, to, pwd, frm, server_addr, client_addr, txtime, repeat]


def Configure():
    print()
    print()
    print()
    print()
    print()
    print()
    print()
    print('{:^80}'.format("******************************"))
    print('{:^80}'.format("Network Throughput Test"))
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

    print()
    txtime = input("Enter time to transmit for each iterations: ")
    try:
        int(repeat)
    except ValueError:
        logging.error("You must enter a valid number > 0.1 using numbers and decimal points only")
        sys.exit()
    else:
        os.system("cls")
        time.sleep(0.25)

    print("Test will be run with the following settings")
    print("Server address = " + server_addr)
    print("Client address = " + client_addr)
    print("Iterations = " + str(repeat))
    print("Transmit Time = " + str(txtime))
    print()

    answer = input("Do you want to start the test with these settings? Y/N: ")
    if answer == "y":
        return [server_addr, client_addr, repeat]
    if answer == "n":
        os.system("cls")
        Configure()


def Bandwidth(server_addr, client_addr, iterations, logfile):

    from subprocess import Popen

    
    server_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -s -P 1 -B " + server_addr + " -p "
    client_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -t 0.1 -y C -c " + server_addr + " -B " + client_addr + " -p "

    Utils().run_iperf(server_cmd, client_cmd, iterations)



def Report(repeat, txtime, logfile):
    # open the file in universal line ending mode 
    with open(logfile, 'rU') as infile:
      # read the file as a dictionary for each row ({header : value})
      reader = csv.DictReader(infile)
      data = {}
      for row in reader:
        for header, value in row.items():
          try:
            data[header].append(value)
          except KeyError:
            data[header] = [value]

    # extract the variables you want
    bps = data['bits_per_second']
    tbytes = data['transferred_bytes']

    tbytes = [int(x) for x in tbytes]
    bps = [int(x) for x in bps]

    tbytesmean = mean(tbytes)
    avgkbytes = tbytesmean / 1024
    #print(tbytesmean)
    #print(avgkbytes)

    bpsmean = (mean(bps))
    avgkbps = bpsmean / 1000

    logging.info("")
    logging.info("**********************************")
    logging.info("********** TEST SUMMARY **********")
    logging.info("**********************************")
    logging.info("")
    logging.info("Iterations performed = " + repeat)
    logging.info("Transmit time in seconds performed = " + txtime)
    logging.info("Average kbytes = " + str(avgkbytes))
    logging.info("Average kbps = " + str(avgkbps))

logfile, email, server, port, to, pwd, frm, server_addr, client_addr, txtime, repeat = Setup()
if server_addr == None or client_addr == None or repeat == None or txtime == None:
    server_addr, client_addr, repeat = Configure()
Bandwidth(server_addr, client_addr, repeat, logfile)
Report(repeat, txtime, logfile)
