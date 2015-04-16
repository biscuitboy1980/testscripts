
#Calculator Program
def menu():
    #logging.info what options you have
    logging.info "Welcome to Geoff's calculator"
    logging.info "Your options are:"
    logging.info " "
    logging.info "1) Addition"
    logging.info "2) Subtraction"
    logging.info "3) Multiplication"
    logging.info "4) Division"
    logging.info "5) Quit Geoff's calculator"
    logging.info " "
    return input ("Choose your option: ")

import time

#this adds two numbers given
def add(a,b):
    logging.info " "
    logging.info a, "+", b, "=", a + b
    logging.info " "
    raw_input("Press Enter key to continue")

#this subtracts two numbers given
def sub(a,b):
    logging.info " "
    logging.info b, "-", a, "=", b - a
    logging.info " "
    raw_input("Press Enter key to continue")
    
#this multiplies two numbers given
def mul(a,b):
    logging.info " "
    logging.info a, "*", b, "=", a * b
    logging.info " "
    raw_input("Press Enter key to continue")
    
#this divides two numbers givent
def div(a,b):
    logging.info " "
    logging.info a, "/", b, "=", a / b
    logging.info " "
    raw_input("Press Enter key to continue")
    
#Now the program really starts, as code is run

loop = 1
choice =0
while loop == 1:
    choice = menu()
    if choice == 1:
        add(input("Add this: "),input("to this: "))
    elif choice == 2:
        sub(input("Subtract this: "),input("from this: "))
    elif choice == 3:
        mul(input("Multiply this: "),input("by this: "))
    elif choice == 4:
        div(input("Divide this: "),input("by this: "))
    elif choice == 5:
        loop = 0

logging.info "Thank you for using Geoff's calculator!"

