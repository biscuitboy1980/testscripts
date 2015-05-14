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

    while processLoopsDone < processLoopsToRun:
        #com_port1.write(chr(sendAsciiCharacter)) # Use this for python2.7
        com_port1.write(chr(sendAsciiCharacter).encode('latin'))  # Use this for python3 ->
        byteSentTime = time.time()
        logCounter += 1
        bytesSentCounter += 1
        if bytesSentCounter == amountOfBytesToSendInOneSecond:
            sleepStartTime = time.time()
            returnBuffer[0] = 'Tx'
            returnBuffer[1] = logCounter
            returnBuffer[2] = bytesSentCounter
            returnBuffer[3] = hex(sendAsciiCharacter)
            returnBuffer[4] = byteSentTime
            messageQueue.put('TxReady')
            event.wait()
            processLoopsDone += 1
            time.sleep(busLoadWaitTime)
            print('Time asleep = ' + repr((time.time() - sleepStartTime) * 1000) + 'ms')
            print('Finished %d / %d transmit loops' % (processLoopsDone, processLoopsToRun))
            bytesSentCounter = 0
        if sendAsciiCharacter == 255:
            sendAsciiCharacter = 0
        else:
            sendAsciiCharacter += 1
    print('Tx FINISHED')

# function for receiving x Bytes via UART
# def receive_data(comPort, baudrate, bitsPerByte, busLoad, processLoop, output, lock):
def receive_data(comPort, baudrate, bitsPerByte, busLoad, processLoopsToRun, returnBuffer, messageQueue, event):
    byteStreamCounter = 0
    timeNothingReceivedCounter = 0
    startTimeNothingReceived = 0
    timeNothingReceived = 0
    logCounter = 0
    processLoopsDone = 0
    bytesReceivedCounter = 0
    receivedByte = None

    try:
        com_port2 = serial.Serial(comPort, baudrate, bytesize=serial.EIGHTBITS, parity=serial.PARITY_NONE, stopbits=serial.STOPBITS_ONE, timeout=0)
    except serial.SerialException as ex:
        print('Port {0} is unavailable: {1}'.format(comPort, ex))
    com_port2.flushInput()

    amountOfBytesToSendInOneSecond = calc_bytes_to_send(baudrate, bitsPerByte, busLoad)

    while processLoopsDone < processLoopsToRun:
        try:
            receivedByte = ord(com_port2.read(1))
            byteReceivedTime = time.time()
            logCounter += 1
            bytesReceivedCounter += 1
        except:
            if timeNothingReceivedCounter == 0:
                startTimeNothingReceived = time.time()
                timeNothingReceivedCounter = 1
            else:
                timeNothingReceived = (time.time() - startTimeNothingReceived)
            if timeNothingReceived > 10:
                messageQueue.put('RxStuck')
                timeNothingReceived = 0
                timeNothingReceivedCounter = 0
        if bytesReceivedCounter == amountOfBytesToSendInOneSecond:
            returnBuffer[0] = 'Rx'
            returnBuffer[1] = logCounter
            returnBuffer[2] = bytesReceivedCounter
            returnBuffer[3] = hex(receivedByte)
            returnBuffer[4] = byteReceivedTime

            messageQueue.put('RxReady')
            event.wait()
            timeNothingReceivedCounter = 0
            processLoopsDone += 1
            bytesReceivedCounter = 0
    print('Rx FINISHED')

if __name__ == '__main__':

    messageQueue = mp.Queue()
    event = mp.Event()
    manager = mp.Manager()
    returnBufferTx = manager.dict()
    returnBufferRx = manager.dict()

    bitsPerByte = 10
    busLoadPercent = 100
    baudrate = 115200
    transferDataSeconds = 600
    testLoopsExecuted = 0
    txFlag = False
    rxFlag = False
    openFileFirstTimeFlag = False
    data = None
    logFileTimeStamp = None

    # Setup a list of processes that we want to run
    process1 = mp.Process(target=send_data, args=('COM15', baudrate, bitsPerByte, busLoadPercent, transferDataSeconds, returnBufferTx, messageQueue,event,))
    process2 = mp.Process(target=receive_data, args=('COM16', baudrate, bitsPerByte, busLoadPercent, transferDataSeconds, returnBufferRx, messageQueue,event,))
    # Run processes
    process2.start()
    process1.start()

    logFileTimeStamp = time.strftime("%d-%m-%Y %H:%M:%S", time.gmtime())
    print(logFileTimeStamp)
    event.set()

    if process1.is_alive():
        print('Process 1 running')
    else:
        print('Process 1 not running')
    if process2.is_alive():
        print('Process 2 running')
    else:
        print('Process 2 not running')

    while 1:
        event.clear()
        if messageQueue.empty() == False:
            receivedMessage = messageQueue.get()
            print('Read Queue ' + receivedMessage)
            if receivedMessage == 'TxReady':
                txFlag = True
            elif receivedMessage == 'RxReady':
                rxFlag = True
            if txFlag & rxFlag:
                startTime = time.time()
                print(returnBufferTx)
                print(returnBufferRx)
                timeDiffTxRxAccumulated = 0
                if returnBufferTx[1] == returnBufferRx[1]:
                    if returnBufferTx[2] == returnBufferRx[2]:
                        if returnBufferTx[3] == returnBufferRx[3]:
                            latency = (returnBufferRx[4] - returnBufferTx[4]) * 1000 * 1000
                            print('Latency = %.3f us' %latency)
                            txFlag = False
                            rxFlag = False
                            testLoopsExecuted += 1
                            with open('Proxi_COM_Log.csv', 'a') as csvfile:
                                fieldnames = ['Iteration', 'Direction_Tx', 'Byte_All_Tx', 'Byte_Sequence_Tx', 'Value_Tx', 'Time_Tx', 'Direction_Rx', 'Byte_All_Rx', 'Byte_Sequence_Rx', 'Value_Rx', 'Time_Rx', 'Latency Tx -> Rx']
                                writer = csv.DictWriter(csvfile, fieldnames=fieldnames)
                                if openFileFirstTimeFlag == False:
                                    writer.writerow({'Iteration': logFileTimeStamp})
                                    writer.writeheader()
                                    openFileFirstTimeFlag = True
                                writer.writerow({'Iteration': testLoopsExecuted,
                                                 'Direction_Tx': returnBufferTx[0], 'Byte_All_Tx': returnBufferTx[1], 'Byte_Sequence_Tx': returnBufferTx[2], 'Value_Tx': returnBufferTx[3], 'Time_Tx': returnBufferTx[4],
                                                 'Direction_Rx': returnBufferRx[0], 'Byte_All_Rx': returnBufferRx[1], 'Byte_Sequence_Rx': returnBufferRx[2], 'Value_Rx': returnBufferRx[3], 'Time_Rx': returnBufferRx[4],
                                                 'Latency Tx -> Rx': latency})
                            event.set()
                        else:
                            print('Last Byte in sequence not correct')
                    else:
                        print('Amount of Bytes in sequence not correct')
                else:
                    print('Amount of Bytes send overall is not correct')
                processTime = time.time() - startTime
                print('Result processing took ' + repr(processTime * 1000) + 'ms')
            elif receivedMessage == 'TxStuck':
                print('Tx process is no longer working')
            elif receivedMessage == 'RxStuck':
                print('Rx process is no longer working')
            else:
                if rxFlag == True:
                    print('Waiting for Tx')
                if txFlag == True:
                    print('Waiting for Rx')
        elif testLoopsExecuted == transferDataSeconds:
            break
        else:
            time.sleep(.001)

    process1.join(1)
    process2.join(1)

    if process1.is_alive():
        print('Process 1 running')
        process1.terminate()
    else:
        print('Process 1 not running')
    if process2.is_alive():
        print('Process 2 running')
        process2.terminate()
    else:
        print('Process 2 not running')
