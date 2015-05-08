from CommonUtils import Utils
from config import *

import time
import logging
import os
import re
import argparse
import csv
from subprocess import Popen
from io import StringIO
from statistics import mean
from argparse import RawTextHelpFormatter
from subprocess import Popen, PIPE, STDOUT


def Setup():
    # gets current date/time
    now = Utils().datetimenow(1)

    # defines options/arguments
    parser = argparse.ArgumentParser(description="Network Latency Test Options")
    parser.add_argument("-e","--email", help="sends an email using the parameters in config.py", action="store_true", required=False)
    parser.add_argument("-s","--source", help="sets the source IP address", required=False)
    parser.add_argument("-d","--destination", help="sets the destination IP address", required=False)
    parser.add_argument("-i","--iterations", help="configures the number of iterations to run", required=False)
    parser.add_argument("-b","--bytes", help="configures the number of bytes to send", required=False)
    args = parser.parse_args()

    # puts options/arguments into variables
    source = args.source
    dest = args.destination
    repeat = args.iterations
    size = args.bytes
    email = args.email
    #txtime = args.time


    # gets email configuration from config.py and puts into variables
    server = EMAIL_SERVER
    port = EMAIL_PORT
    frm = EMAIL_FROM
    to = EMAIL_TO
    pwd = EMAIL_PASSWORD

    # specifies logfile name
    logfile = "C:/Temp/Latency_Test_" + size + "bytes_" + now + ".csv"


    # checks to see if logfile directory exists and creates it if not
    dir = os.path.dirname(logfile)
    if not os.path.exists(dir):
        os.makedirs(dir)

    # creates logfile
    Utils().Logger(logfile, 2)
    os.system("cls")



    #return [logfile, email, server, port, to, pwd, frm, server_addr, client_addr, txtime, repeat]
    return [logfile, email, server, port, to, pwd, frm, source, dest, repeat, size]

def Configure():
    #sets up test if no parameters were defined when running via command line
    print()
    print()
    print()
    print()
    print()
    print()
    print()
    print('{:^80}'.format("******************************"))
    print('{:^80}'.format("Network Latency Test"))
    print('{:^80}'.format("******************************"))
    time.sleep(1.5)
    os.system("cls")

    #sets source IP address
    print("Enter source IP address")
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

    #sets destination IP address
    print("Enter destination IP address")
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
    
    #sets byte size to send in ping message
    print()
    repeat = input("Enter the byte size you want to execute (32-65500): ")
    try:
        int(repeat)
    except ValueError:
        logging.error("You must enter a valid byte size (32 - 65500) using numbers only")
        sys.exit()
    else:
        os.system("cls")
        time.sleep(0.25)

   
    #sets number of iterations to perform
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
    print("Source address = " + source)
    print("Destination address = " + dest)
    print("Iterations = " + str(repeat))
    print()

    answer = input("Do you want to start the test with these settings? Y/N: ")
    if answer == "y":
        return [source, dest, repeat]
    if answer == "n":
        os.system("cls")
        Configure()

def Latency(source, dest, repeat, size, logfile):

    #writes headings to csv file
    
    headings = ["Iteration", "Sent (bytes)", "Time (ms)"]
    with open(logfile, 'a') as f:
        writer = csv.writer(f)
        writer.writerow(headings)
    
    #alternate metho for sending commands, will screw up logging, haven't had time to figure out how to make this work
    #p1 = subprocess.Popen("ping.exe -w 5000 -n " + str(repeat) + " -l " + str(size) + " -S " + source + " " + dest, stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True)
    #out, err = p1.communicate()
    #print(out)

    #p1 = subprocess.Popen("iperf -c " + source + " -u -b 10m -p 50000")
    #with Popen("iperf -s -u -y C -i 1 -B " + dest + " -p 50000", stdout=PIPE, bufsize=1, universal_newlines=True) as p, StringIO() as buf:
    #    for line in p.stdout:
    #        print(line, end='')
    #        #buf.write(line)
    #        logging.info(line)
    ##    out = buf.getvalue()
    ##rc = p.returncode

    #pings with parameters specified during configure or via command line arguments
    cnt = 0
    with Popen("ping.exe -w 5000 -n " + str(repeat) + " -l " + str(size) + " -S " + source + " " + dest, stdout=PIPE, bufsize=1, universal_newlines=True) as p, StringIO() as buf:
        for line in p.stdout:
            print(line, end='')
            buf.write(line)
            print(cnt)
            cnt = cnt + 1
        out = buf.getvalue()
    rc = p.returncode

    #find response times and byte sizes and stores to variable
    tm = re.findall("(?<=time)(.*)(?<=ms)", out)
    tm = str(tm).replace("=", "").replace("ms", "").replace("[", "").replace("]", "").replace("'", "").replace(" ", "")
    byt = re.findall("(?<=bytes=)(.*)(?<=time)", out)
    byt = str(byt).replace(" time", "").replace("[", "").replace("]", "").replace("'", "").replace(" ", "")

    #finds min, max, avg response times and stores to variable
    min = re.findall("(?<=Minimum =)(.*)(?<=, M)", out)
    min = str(min).replace(", M", "").replace(" ", "").replace("[", "").replace("]", "")
    avg = re.findall("(?<=Average =)(.*)(?<=s)", out)
    avg = str(avg).replace(" ", "").replace("[", "").replace("]", "")
    max = re.findall("(?<=Maximum =)(.*)(?<=,)", out)
    max = str(max).replace(" ", "").replace(",", "").replace("[", "").replace("]", "")

    #finds lost % lost and stores to variable
    lost = re.findall("(?<=Lost =)(.*)(?<=\()", out)
    lost = str(lost).replace("(", "").replace("[", "").replace("]", "").replace(" ", "").replace("'", "")
    pctlost = "0"
    if lost != "0":
        pctlost = float(lost) / float(repeat)
        pctlost = "{:.2%}".format(pctlost)

    #seperates values with a ,
    tm = tm.split(",")
    byt = byt.split(",")

    #puts time, bytes, and iterations into lists
    tm = list(tm)
    byt = list(byt)
    iters = list(range(1, int(repeat) + 1))

    #formats and appends csv file with these values (this is only done at the end of the test, if you interrupt while the test is in progress nothing will be written to the logfile
    rows = zip(iters,byt,tm)
    with open(logfile, 'a', newline="") as f:
        writer = csv.writer(f)
        for row in rows:
            writer.writerow(row)

    #appends logfile with summary data
    with open(logfile,'a') as f: 
        f.write("Test Summary \n Minimum = " + min + "\n Maximum = " + max +"\n Average = " + avg + "\n Lost = " + lost + ", " + pctlost)

logfile, email, server, port, to, pwd, frm, source, dest, repeat, size = Setup()
if source == None or dest == None or repeat == None:
    source, dest, repeat = Configure()
Latency(source, dest, repeat, size, logfile)
