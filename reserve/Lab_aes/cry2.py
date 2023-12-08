from Crypto.Cipher import AES

password = b'Crazy_KFC_vivo50' #秘钥，b就是表示为bytes类型
text = b'\xf8\x0d\x54\x0a\x0b\x08\x78\xa9\xfa\x83\xa5\x7b\x86\x69\xb2\xaf' #需要加密的内容，bytes类型
aes = AES.new(password,AES.MODE_ECB) #创建一个aes对象
# AES.MODE_ECB 表示模式是ECB模式

den_text = aes.decrypt(text) # 解密密文
print("明文：",den_text)
