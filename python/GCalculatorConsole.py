
#Calculator Program
def menu():
    #print what options you have
    print "Welcome to Geoff's calculator"
    print "Your options are:"
    print " "
    print "1) Addition"
    print "2) Subtraction"
    print "3) Multiplication"
    print "4) Division"
    print "5) Quit Geoff's calculator"
    print " "
    return input ("Choose your option: ")

import time

#this adds two numbers given
def add(a,b):
    print " "
    print a, "+", b, "=", a + b
    print " "
    raw_input("Press Enter key to continue")

#this subtracts two numbers given
def sub(a,b):
    print " "
    print b, "-", a, "=", b - a
    print " "
    raw_input("Press Enter key to continue")
    
#this multiplies two numbers given
def mul(a,b):
    print " "
    print a, "*", b, "=", a * b
    print " "
    raw_input("Press Enter key to continue")
    
#this divides two numbers givent
def div(a,b):
    print " "
    print a, "/", b, "=", a / b
    print " "
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

print "Thank you for using Geoff's calculator!"

