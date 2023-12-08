from Crypto.Cipher import ARC4
import base64

def rc4_encrypt(data, key1):        # 加密
    key = bytes(key1, encoding='utf-8')
    enc = ARC4.new(key)
    res = enc.encrypt(data.encode('utf-8'))
    res=base64.b64encode(res)
    res = str(res,'utf-8')
    return res

def rc4_decrypt(data, key1):        # 解密
    data = base64.b64decode(data)
    key = bytes(key1, encoding='utf-8')
    enc = ARC4.new(key)
    res = enc.decrypt(data)
    res = str(res,'gbk')
    return res


if __name__ == "__main__":
    data = b'\x07\x9B\xE8\xAC\x68\xAB\xAF\x3E\xC4\x66\xD1\x0E\x88\x06\x8A\x11'  # 需要加密的内容
    key = b'Scr1w666'  # 加密key
    encrypt_data = data    # 加密方法

    print('解密后:',rc4_decrypt(encrypt_data, key))         # 解密方法
