import os, time
 
def recurse(path, root):
        flist = []
        noval = []
        if root:
                noval = [([flist.append(elem[0] + "\\" + f) 
                for f in elem[2] if elem[2]], flist.append(elem[0])) 
                for elem in os.walk(path, True)]
                return flist
        else:
                noval = [([flist.append(elem[0] + "\\" + f) 
                for f in elem[2] if elem[2]], [flist.append(elem[0] + "\\" + f) 
                for f in elem[1] if elem[1]]) for elem in os.walk(path, True)]
                return flist
 
path_to_watch = "c:\\temp"
before = recurse(path_to_watch, False)
for i in range(1, 15):
    time.sleep(5)
    after = recurse(path_to_watch, False)
    added = [f for f in after if not f in before]
    removed = [f for f in before if not f in after]
    if added: print "Added: ", ", ".join(added)
    if removed: print "Removed: ", ", ".join(removed)
    before = after

	#comment