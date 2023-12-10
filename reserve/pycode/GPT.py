from Crypto.Util.number import *


enc = '8b2e4e858126bc8478d6a6a485215f03'

def extract_number(x):
    x = x ^ (x >> 11)
    x = x ^ ((x << 7) & 2022072721)
    x = x ^ ((x << 15) & 2323163360)
    x = x ^ (x >> 18)
    return x

def transform(m):
    new_message = b''

    l = len(m)
    for i in range(l // 4):
        enc = m[i * 4: (i + 1) * 4]
        enc = bytes_to_long(enc)
        enc = extract_number(enc)
        enc = long_to_bytes(enc, 4)
        new_message += enc

    return new_message

if __name__ == '__main__':
    num = input('input your number:')
    tmp = bytes.fromhex(num)
    res = transform(tmp)

    if enc == res:
        print('ok, your flag: DASCTF{{{name}}}'.format(name=num))
    else:
        print('wrong')
