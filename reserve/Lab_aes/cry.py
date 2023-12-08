# 导入PyCryptodome库
from Crypto.Cipher import AES
from Crypto.Util.Padding import pad, unpad

# 定义一个AES解密函数
def aes_decrypt(ciphertext, key, mode, iv=None):
    # 根据模式创建一个AES对象
    if mode == AES.MODE_ECB:
        cipher = AES.new(key, mode)
    elif mode == AES.MODE_CBC or mode == AES.MODE_CFB or mode == AES.MODE_OFB:
        cipher = AES.new(key, mode, iv)
    else:
        raise ValueError("Invalid mode")
    # 解密密文并去除填充
    plaintext = unpad(cipher.decrypt(ciphertext), AES.block_size)
    # 返回明文
    return plaintext

# 调用AES解密函数，传入密文，密钥，模式和填充方式
ciphertext = b'\xf8\x0d\x54\x0a\x0b\x08\x78\xa9\xfa\x83\xa5\x7b\x86\x69\xb2\xaf'
key = b'\x01\x02\x03\x04\x05\x06\x07\x08\x09\x0a\x0b\x0c\x0d\x0e\x0f\x10'
mode = AES.MODE_ECB
plaintext = aes_decrypt(ciphertext, key, mode)
# 打印明文
print(plaintext)
