a = [2 , 3, 5, 7, 11 ,13,17,19,23]
b = [0x33,0x21,0x22,0x21,0x35,0x7c,0x62,0x65,0x6e]
for i in range(9):
    a[i] = a[i] +0x41
    a[i] = a[i] ^b[i]
"".join(chr(a[i]) for i in range(9))
print() 
#pediy2016COOL1234567
