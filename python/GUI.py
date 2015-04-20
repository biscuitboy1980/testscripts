#import Tkinter
#from Tkinter import *
#import time
#import re
#from CommonUtils import Utils

#class SetupSerial():
    
#    def option_changed(*args):
#        print "the user chose the value {}".format(txcom.get())

#    coms = Utils().get_com_ports()

#    master = Tk()

#    baud = StringVar()
#    baud.set("Baud")
#    baud.trace("w", option_changed)
#    lst = ["9600","14400","19200","38400","57600","115200", "128000"]
#    w = OptionMenu(master, baud, *lst)
#    w.pack()

#    txcom = StringVar()
#    txcom.set("Transmit Port")
#    txcom.trace("w", option_changed)
#    w = OptionMenu(master, txcom, *coms)
#    w.pack()

#    rxcom = StringVar()
#    rxcom.set("Receive Port")
#    rxcom.trace("w", option_changed)
#    w = OptionMenu(master, rxcom, *coms)
#    w.pack()

#    iteration = Label(master, text="# of Iterations")
#    iteration.pack( side = LEFT)
#    iteration = Entry(master, bd =5)
#    iteration.pack(side = LEFT)

#    b = Button(master, text="Start", command=callback)
#    b.pack()

#    mainloop()