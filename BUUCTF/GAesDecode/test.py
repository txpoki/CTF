r_sbox = [82, 9, 106, 213, 48, 54, 165, 56, 191, 64, 163, 158, 129, 243, 215, 251, 124, 227, 57, 130, 155, 47, 255, 135, 52, 142, 67, 68, 196, 222, 233, 203, 84, 123, 148, 50, 166, 194, 35, 61, 238, 76, 149, 11, 66, 250, 195, 78, 8, 46, 161, 102, 40, 217, 36, 178, 118, 91, 162, 73, 109, 139, 209, 37, 114, 248, 246, 100, 134, 104, 152, 22, 212, 164, 92, 204, 93, 101, 182, 146, 108, 112, 72, 80, 253, 237, 185, 218, 94, 21, 70, 87, 167, 141, 157, 132, 144, 216, 171, 0, 140, 188, 211, 10, 247, 228, 88, 5, 184, 179, 69, 6, 208, 44, 30, 143, 202, 63, 15, 2, 193, 175, 189, 3, 1, 19, 138, 107, 58, 145, 17, 65, 79, 103, 220, 234, 151, 242, 207, 206, 240, 180, 230, 115, 150, 172, 116, 34, 231, 173, 53, 133, 226, 249, 55, 232, 28, 117, 223, 110, 71, 241, 26, 113, 29, 41, 197, 137, 111, 183, 98, 14, 170, 24, 190, 27, 252, 86, 62, 75, 198, 210, 121, 32, 154, 219, 192, 254, 120, 205, 90, 244, 31, 221, 168, 51, 136, 7, 199, 49, 177, 18, 16, 89, 39, 128, 236, 95, 96, 81, 127, 169, 25, 181, 74, 13, 45, 229, 122, 159, 147, 201, 156, 239, 160, 224, 59, 77, 174, 42, 245, 176, 200, 235, 187, 60, 131, 83, 153, 97, 23, 43, 4, 126, 186, 119, 214, 38, 225, 105, 20, 99, 85, 33, 12, 125]
def r_substitute(states):
    for i in range(4):
        for j in range(4):
            states[i][j] = r_sbox[states[i][j]]
    return states 
def r_shiftRows(states):
    for i in range(4):
        temp = [states[i][j] for j in range(4)]
        states[i] = [temp[(j-i)%4] for j in range(4)]
    return states 
def r_m2(a):
    if a&1 == 1:
        return ((a^29)>>1)|0x80 
    else:
        return a>>1 
 
def r_mix(states):
    for j in range(4):
        temp = [states[i][j] for i in range(4)]
        a0123 = temp[0]^temp[1]^temp[2]^temp[3]
        t = [temp[0]^a0123, temp[1]^a0123, temp[2]^a0123, temp[3]^a0123]
        for ma0 in range(0x100):
            ma1 = t[0]^ma0^r_m2(ma0)
            ma2 = t[1]^ma1^r_m2(ma1) 
            ma3 = t[2]^ma2^r_m2(ma2)
            mat = t[3]^ma3^r_m2(ma3) 
            if mat == ma0:
                states[0][j] = r_m2(ma0)
                states[1][j] = r_m2(ma1)
                states[2][j] = r_m2(ma2)
                states[3][j] = r_m2(ma3)
                break 
    return states 
#轮加密
def andRoundKey(states, rkey):
    return [[states[i][j]^rkey[j*4+i]  for j in range(4)] for i in range(4)]
def state_in(cipher):
    return [[cipher[i*4+j]  for j in range(4)] for i in range(4)]
 
def state_out(states):
    s = b''
    for i in range(4):
        for j in range(4):
            s += bytes([states[j][i]])
    return s 
def decrypt(cipher):
    for i in range(0, len(cipher),16):
        c = cipher[i: i+16]
        states = state_in(c)
        #print(list(c), states)
        for j in range(10,-1,-1):   #11轮每轮先异或key
            roundKey = key[j*16: j*16+16]
            print(roundKey)
            if j == 0:
                states = andRoundKey(states, roundKey)
            elif j < 10:
                states = andRoundKey(states, roundKey)
                states = r_mix(states)
                states = r_shiftRows(states)
                states = r_substitute(states)
            else:
                states = andRoundKey(states, roundKey)
                states = r_shiftRows(states)
                states = r_substitute(states)
        flag = state_out(states)
        print(flag.decode(), end='')
 
            
 
from base64 import *
 
cipher = "kNk3Qz+l/kLpGuKxf5iGE9cOoTmmn9Ac+UdF4b2CHqU="
key =  b"This is a AES-like encryption algorithm. However, we do some change. Therefore, you cannot directly use security class to decrypt the message. Our challenge is to find the plain text of this encrypt message with th fixed key. "
cipher = b64decode(cipher)                    
#print(cipher)
        
decrypt(cipher)
#flag{aes_is_the_best_encryption}