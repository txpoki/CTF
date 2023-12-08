import zipfile
f = zipfile.ZipFile("flag1.zip", 'r')
while 1:
    try:
        name = f.namelist()[0]
        print(name)
        f.extractall()
        f = zipfile.ZipFile(name, 'r')
    except:
        break

