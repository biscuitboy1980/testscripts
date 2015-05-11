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
    print('{:^80}'.format("Network Throughput Test"))
    print('{:^80}'.format("******************************"))
    time.sleep(1.5)
    os.system("cls")

    ##gets all available IP addresses on windows machine
    import socket
    ipaddr = [i[4][0] for i in socket.getaddrinfo(socket.gethostname(), None)]
    ipaddr = re.findall( r'[0-9]+(?:\.[0-9]+){3}', str(ipaddr))
    ipdict = dict(enumerate(line.strip() for line in ipaddr))

    #sets server IP address
    print("Select the server IP address")
    print()
    num = 0
    for e in ipaddr:
        num = num + 1
        print(str(num) + ". " + e)
    print()
    answer = input("Make your choice: ")
    try:
        answer = int(answer) - 1
    except ValueError:
        logging.error("You must enter one of the numbers displayed as an option")
    else:
        ipdictkey = answer
        answer = ipdict.get(answer)
        server_addr = answer
        del ipdict[ipdictkey]
        ipaddr.remove(answer)
        ipdict = dict(enumerate(line.strip() for line in ipaddr)) #updates coms dictionary
        os.system("cls")
        time.sleep(0.25)
      

    #sets client IP address
    print("Select the client IP address")
    print()
    num = 0
    for e in ipaddr:
        num = num + 1
        print(str(num) + ". " + e)
    print()
    answer = input("Make your choice: ")
    try:
        answer = int(answer) - 1
    except ValueError:
        logging.error("You must enter one of the numbers displayed as an option")
    else:
        ipdictkey = answer
        answer = ipdict.get(answer)
        client_addr = answer
        os.system("cls")
        time.sleep(0.25)
    
    #configures the number of iterations to perform
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

    #prints summary of parameters to use for the test
    print("Test will be run with the following settings")
    print("Server address = " + server_addr)
    print("Client address = " + client_addr)
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

    #iperf commands to use based off of parameters entered 
    server_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -s -P 1 -B " + server_addr + " -p "
    client_cmd = "C:\software\iperf\iperf-2.0.5-3-win32\iperf.exe -y C -c " + server_addr + " -B " + client_addr + " -p "

    Utils().run_iperf(server_cmd, client_cmd, iterations)



def Report(repeat, logfile):
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
    kbps = data['bits_per_second']
    tbytes = data['transferred_bytes']

    #extracts minimum and maximum kbps from data
    max_kbps = max(kbps)
    min_kbps = min(kbps)

    #iterates through data for writing to csv file
    tbytes = [int(x) for x in tbytes]
    kbps = [int(x) for x in kbps]

    #gets average transmitted bytes and kbps
    tbytesmean = mean(tbytes)
    avgkbytes = tbytesmean / 1024
    kbpsmean = (mean(kbps))
    avgkbps = kbpsmean / 1000

    logging.info("")
    logging.info("**********************************")
    logging.info("********** TEST SUMMARY **********")
    logging.info("**********************************")
    logging.info("")
    logging.info("Iterations performed = " + repeat)
    logging.info("Kbytes per second transferred = " + str(avgkbytes))
    logging.info("Minimum kbps = " + str(min_kbps))
    logging.info("Maximum kbps = " + str(max_kbps))
    logging.info("Average kbps = " + str(avgkbps))

logfile, email, server, port, to, pwd, frm, server_addr, client_addr, repeat = Setup()
if server_addr == None or client_addr == None or repeat == None:
    server_addr, client_addr, repeat = Configure()
Bandwidth(server_addr, client_addr, repeat, logfile)
Report(repeat, logfile)
