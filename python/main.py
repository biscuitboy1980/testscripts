from CommonUtils import Utils
import operator 
import logging
import time

now = Utils().datetimenow(1)
logfile = "C:/Temp/testing/python_log_" + now + ".log"

#Utils().Logger(logfile)

Utils().SendEmail("smtp.gmail.com", "587", "geoff.guenther@powerbyproxi.com", "geoff.guenther@powerbyproxi.com", "Gunner2015", "Test Results", "All tests passed", "C:/Temp/testing/python_log_20150416_124243.log")

#def SerialTest():
#    passed, failed, iterations = Utils().SendSerial(0, 5, "U"*256, 2, 9600)

#    if passed == 0:
#        logging.warn("All tests failed")
#        result = Utils().MsgBox("All tests failed", "Failure", 1, 4)
#        if result == 10:
#            SerialTest()
#        else:
#            Utils().openFile(logfile)
#    elif failed == 0:
#        logging.info("All tests passed")
#        result = Utils().MsgBox("All tests passed", "Passed", 0, 3)
#        Utils().openFile(logfile)
#    else:
#        num = Utils().Percentage(passed,iterations)
#        logging.warn(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)")
#        result = Utils().MsgBox(str(passed) + " out of " + str(iterations) + " of the run tests passed (" + str(num) + "%)", "Results", 5, 1)
#        if result == 4:
#            SerialTest()
#        else:
#            Utils().openFile(logfile)


#SerialTest()



