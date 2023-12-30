from Crypto.Util import number

enc = '8b2e4e858126bc8478d6a6a485215f03'

def inverse_right(res, shift, bits=32):
    tmp = res
    x=bits // shift
    for i in range(x):
        d = tmp>>shift
        tmp = res ^ (d)
    return tmp
#1000 1011 0010 1110 0100 1110 1000 0101
#1111 1111 1111 1111 1111 1111 0001 1001
#                      11 1111 1111 1111
#1111 1111 1111 1111 1100 0000 1110 0110
# right shift with mask inverse
def inverse_right_mask(res, shift, mask, bits=32):
    tmp = res
    for i in range(bits // shift):
        tmp = res ^ tmp >> shift & mask
    return tmp

# left shift inverse
def inverse_left(res, shift, bits=32):
    tmp = res
    for i in range(bits // shift):
        tmp = res ^ tmp << shift
    return tmp

# left shift with mask inverse
def inverse_left_mask(res, shift, mask, bits=32):
    tmp = res
    for i in range(bits // shift):
        tmp = res ^ tmp << shift & mask
    return tmp

def extract_number(x):
    # x, x, 11
    x = (x >> 11) ^ x
    x = x ^ ((x << 7) & 2022072721)
    x = x ^ ((x << 15) & 2323163360)
    x = x ^ (x >> 18)
    return x

def recover(y):
    y = inverse_right(y,18)
    y = inverse_left_mask(y,15,2323163360)
    y = inverse_left_mask(y,7,2022072721)
    y = inverse_right(y,11)
    return y&0xffffffff

def transform(m: bytes):
    new_message = b''
    l = len(m)
    for i in range(l // 4):
        enc = m[i * 4:i * 4 + 4]
        enc = number.bytes_to_long(enc)
        enc = extract_number(enc)
        enc = number.long_to_bytes(enc, 4)
        new_message += enc
    return new_message
    

#if __name__ == "__main__":
#    num = input("input your number")
#    tmp = bytes.fromhex(num)
#    res = transform(tmp).hex()
#    if enc == res:
#        print("ok,your flag : DASCTF{{{name}}}".format(name=num))
#    else:
#        print("wrong")

new_message = b''
enc = bytes.fromhex(enc)
l = len(enc)
for i in range(l // 4):
    dec = enc[i * 4:i * 4 + 4]
    dec = number.bytes_to_long(dec)
    dec = recover(dec)
    dec = number.long_to_bytes(dec, 4)
    new_message += dec

print(new_message.hex())

