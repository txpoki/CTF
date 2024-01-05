from Crypto.Util.number import *
from Crypto.Cipher import DES
from base64 import *

ciphertext=long_to_bytes(0x0723105D5C12217DCDC3601F5ECB54DA9CCEC2279F1684A13A0D716D17217F4C9EA85FF1A42795731CA3C55D3A4D7BEA)
table='1234567890'

for i1 in table:
    for i2 in table:
        for i3 in table:
            for i4 in table:
                for i5 in table:
                    for i6 in table:
                        key_ = i1+i2+i3+i4+i5+i6
                        string1 = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/'
                        string2 = 'abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ+/'
                        key=b64encode(key_.encode()).decode().translate(str.maketrans(string1,string2)).encode()
                        des = DES.new(key, DES.MODE_ECB)
                        decrypted = des.decrypt(ciphertext) # 解密
                        if b'DASCTF' in decrypted:
                            print(key_)
                            print("解密后的结果：", decrypted)#DASCTF{f771b96b71514bb6bc20f3275fa9404e}
