f = open("4.txt", "a")
a = [0x8A, 0xC7, 0xBC, 0xE6, 0x91, 0xA5,
     ]
b = 0
for i in a:
    b = b ^ i
print(chr(b))
f.write(chr(b))
f.close
