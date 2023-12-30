from Crypto.Util import number

enc = '8b2e4e858126bc8478d6a6a485215f03'
#8b2e4e85 8126bc84 78d6a6a4 85215f03
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
        enc = number.bytes_to_long(enc)
        enc = extract_number(enc)
        enc = number.long_to_bytes(enc, 4)

        new_message += enc

    return new_message

if __name__ == '__main__':
    num = input('input your number:')
    tmp = bytes.fromhex(num)
    res = transform(tmp).hex()

    if res == enc:
        print(f'ok, your flag: DASCTF{{{num}}}')
    else:
        print('wrong')
