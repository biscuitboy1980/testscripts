__author__ = 'dietmar.jung'
import multiprocessing as mp
import serial
import time
import csv

event = None

#messageExchangeQueue = mp.Queue()
# lock = mp.Lock()


# Calculate the amount of Bytes that can be sent at a given baudrate.
# requiredBits = Start Bit, Amount of Bits to send, Parity bit, Stop bits, i.e 1 + 8 + 1 +1 = 11
def calc_bytes_to_send(baudrate, requiredBits, busLoad):
    return (int(baudrate / float(requiredBits) / 100 * busLoad))

def bus_load_wait_time(baudrate, bytesToSend, requiredBits):
    return (1 - ((1 / float(baudrate)) * bytesToSend * requiredBits))


# Calculate the amount of Bytes that can be sent at a given baudrate.
# requiredBits = Start Bit, Amount of Bits to send, Parity bit, Stop bits, i.e 1 + 8 + 1 +1 = 11
def calc_bytes_possible(baudrate, requiredBits):
    amountOfBytes = baudrate / requiredBits
    return amountOfBytes

# function for sending x Bytes via UART
# def send_data(comPort, baudrate, bitsPerByte, busLoad, processLoops, output, lock):
def send_data(comPort, baudrate, bitsPerByte, busLoad, processLoopsToRun, returnBuffer, messageQueue, event):
    dataLogArray = []
    bytesSentCounter = 0
    sendAsciiCharacter = 0
    processLoopsDone = 0
    logCounter = 0

    try:
        com_port1 = serial.Serial(comPort, baudrate, bytesize=serial.EIGHTBITS, parity=serial.PARITY_NONE, stopbits=serial.STOPBITS_ONE, timeout=0)
    except serial.SerialException as ex:
        print('Port {0} is unavailable: {1}'.format(comPort, ex))

    amountOfBytesToSendInOneSecond = calc_bytes_to_send(baudrate, bitsPerByte, busLoad)
    busLoadWaitTime = bus_load_wait_time(baudrate, amountOfBytesToSendInOneSecond, bitsPerByte)

    csvfile = open('UartResultsTxInProcess.csv', 'wt')

    while processLoopsDone < processLoopsToRun:
        #com_port1.write(chr(sendAsciiCharacter)) # Use this for python2.7
        com_port1.write(chr(sendAsciiCharacter).encode('latin'))  # Use this for python3 ->
        array = []
        array.append('Tx:')
        array.append(logCounter)
        array.append(hex(sendAsciiCharacter))
        array.append(time.time())
        returnBuffer[bytesSentCounter] = array
        logCounter += 1

        # inform the RX process that the data block has been sent and is ready for logging
        # also save the data in the log file
        if bytesSentCounter == amountOfBytesToSendInOneSecond:
            sleepStartTime = time.time()
            messageQueue.put('TxReady')
            event.wait()
            dataLogArray.append(array)
            processLoopsDone += 1
            dataLogArrayLength = len(dataLogArray)
            for i in range(dataLogArrayLength):
                csvfile.write(str(dataLogArray[i]) + '\n')
            #print('Log file writing took: ' + repr(((time.time() - sleepStartTime) * 1000)) + 'ms')
            time.sleep(busLoadWaitTime)
            print('Time asleep = ' + repr((time.time() - sleepStartTime) * 1000) + 'ms')
            print('Finished %d / %d transmit loops' % (processLoopsDone, processLoopsToRun))
            dataLogArray = []
            bytesSentCounter = 0
        else:
            bytesSentCounter += 1
        if sendAsciiCharacter == 127:
            sendAsciiCharacter = 0
        else:
            sendAsciiCharacter += 1
    csvfile.close()
    # inform the RX process that the test run has now finished so it can stop the process
    time.sleep(1)
    messageQueue.put('EXIT')
    print('Tx sent EXIT')

# function for receiving x Bytes via UART
# def receive_data(comPort, baudrate, bitsPerByte, busLoad, processLoop, output, lock):
def receive_data(comPort, baudrate, bitsPerByte, busLoad, processLoopsToRun, returnBuffer, messageQueue, event):
    dataLogArray = []
    array = []
    byteStreamCounter = 0
    timeNothingReceivedCounter = 0
    startTimeNothingReceived = 0
    endTimeNothingReceived = 0
    logCounter = 0
    processLoopsDone = 0
    bytesReceivedCounter = 0
    txMessage = None
    receivedByte = None
    messageInQueue = False

    # print('Rx is waiting for event')
    # event.wait()
    # print('Rx has started')

    try:
        com_port2 = serial.Serial(comPort, baudrate, bytesize=serial.EIGHTBITS, parity=serial.PARITY_NONE, stopbits=serial.STOPBITS_ONE, timeout=0)
    except serial.SerialException as ex:
        print('Port {0} is unavailable: {1}'.format(comPort, ex))
    com_port2.flushInput()

    csvfile = open('UartResultsRxInProcess.csv', 'wt')

    amountOfBytesToSendInOneSecond = calc_bytes_to_send(baudrate, bitsPerByte, busLoad)

    # the RX process will get status information from the TX Queue.
    # TX process sends the last Byte it transmitted from the data block
    # It also sends 'EXIT' when all bytes have been transmitted
    while processLoopsDone < processLoopsToRun:
        try:
            receivedByte = ord(com_port2.read(1))
            byteReceivedTime = time.time()
            # if timeNothingReceivedCounter > 0:
            #     dataLogArray.append(repr('No Rx for %5.2f ms' %endTimeNothingReceived))
            #     print('No Rx for %5.2f ms' %endTimeNothingReceived)
            #     timeNothingReceivedCounter = 0
            array = []
            array.append('Rx:')
            array.append(logCounter)
            array.append(hex(receivedByte))
            array.append(byteReceivedTime)
            returnBuffer[bytesReceivedCounter] = array
            #dataLogArray.append(array)
            logCounter += 1
            bytesReceivedCounter += 1
        except:
            if timeNothingReceivedCounter == 0:
                startTimeNothingReceived = time.time()
                timeNothingReceivedCounter = 1
            else:
                endTimeNothingReceived = (time.time() - startTimeNothingReceived) * 1000
                timeNothingReceivedCounter += 1
                # messageQueue.put('RxReady')
                # print 'Onto Queue - Rx Ready'
        if bytesReceivedCounter == amountOfBytesToSendInOneSecond +1:
            messageQueue.put('RxReady')
            event.wait()
            #print('Onto Queue - Rx finished')
            timeNothingReceivedCounter = 0
            processLoopsDone += 1
            dataLogArray.append(array)
            dataLogArrayLength = len(dataLogArray)
            for i in range(dataLogArrayLength):
                csvfile.write(str(dataLogArray[i]) + '\n')
            #print('Log file writing')
            dataLogArray = []
            bytesReceivedCounter = 0
    csvfile.close()

if __name__ == '__main__':

    messageQueue = mp.Queue()
    event = mp.Event()
    manager = mp.Manager()
    returnBufferTx = manager.dict()
    returnBufferRx = manager.dict()

    bitsPerByte = 10
    busLoadPercent = 100
    baudrate = 115200
    transferDataSeconds = 100
    txFlag = False
    rxFlag = False
    data = None

    # Setup a list of processes that we want to run
    process1 = mp.Process(target=send_data, args=('COM15', baudrate, bitsPerByte, busLoadPercent, transferDataSeconds, returnBufferTx, messageQueue,event,))
    process2 = mp.Process(target=receive_data, args=('COM16', baudrate, bitsPerByte, busLoadPercent, transferDataSeconds, returnBufferRx, messageQueue,event,))
    #process3 = mp.Process(target=check_data, args=(messageQueue,))
    # Run processes
    process2.start()
    #time.sleep(.01)
    process1.start()
    #process3.start()

    event.set()

    if process1.is_alive():
        print('Process 1 running')
    else:
        print('Process 1 not running')
    if process2.is_alive():
        print('Process 2 running')
    else:
        print('Process 2 not running')

    time.sleep(.01)
    while 1:
        event.clear()
        if messageQueue.empty() == False:
            receivedMessage = messageQueue.get()
            print('Read Queue ' + receivedMessage)
            if receivedMessage == 'TxReady':
                txFlag = True
                # print(returnBufferTx.values())
                # returnBufferTx = []
            elif receivedMessage == 'RxReady':
                rxFlag = True
                # print(returnBufferRx.values())
                # returnBufferRx = []
            if txFlag & rxFlag:
                startTime = time.time()
                returnBufferTxLength = len(returnBufferTx)
                returnBufferRxLength = len(returnBufferRx)
                timeDiffTxRxAccumulated = 0
                if returnBufferTxLength == returnBufferRxLength:
                    print('Processing Log files') #('Log Buffer length is the same')
                    print('Buffer length = ' + repr(returnBufferTxLength))
                    for bufferLoop in range(returnBufferRxLength):
                        #print(bufferLoop)
                        if returnBufferTx[bufferLoop][1] == returnBufferRx[bufferLoop][1]:
                            if returnBufferTx[bufferLoop][2] == returnBufferRx[bufferLoop][2]:
                                timeDiffTxRx = returnBufferRx[bufferLoop][3] - returnBufferTx[bufferLoop][3]
                                timeDiffTxRxAccumulated += timeDiffTxRx
                    print('Latency = %.3f ms' %(timeDiffTxRxAccumulated * 1000 / (bufferLoop + 1)))
                txFlag = False
                rxFlag = False
                event.set()
                processTime = time.time() - startTime
                print('Result processing took ' + repr(processTime * 1000) + 'ms')
            else:
                print('Waiting for Tx or Rx')
        else:
            time.sleep(.001)

    process1.join()
    process2.join()

    if process1.is_alive():
        print('Process 1 running')
    else:
        print('Process 1 not running')
    if process2.is_alive():
        print('Process 2 running')
    else:
        print('Process 2 not running')

