# 定义一个RC4解密函数，它接受密钥和密文作为参数，然后返回明文
def rc4_decrypt(key, ciphertext):
    # 初始化S盒，它是一个256字节的列表，用来存储0到255的互不重复的元素
    S = list(range(256))
    # 初始化j，它是一个整数，用来记录S盒的交换位置
    j = 0
    # 根据密钥打乱S盒，这个过程叫做KSA（the Key-Scheduling Algorithm）
    for i in range(256):
        # j等于j加上S盒的第i个元素和密钥的第i个字符的ASCII码，再模256
        j = (j + S[i] + ord(key[i % len(key)])) % 256
        # 交换S盒的第i个元素和第j个元素
        S[i], S[j] = S[j], S[i]
    # 初始化i和j，它们都是整数，用来记录S盒的交换位置
    i = 0
    j = 0
    # 初始化out，它是一个空列表，用来存储解密后的字符
    out = []
    # 遍历密文的每个字符，这个过程叫做PRGA（the Pseudo-Random Generation Algorithm）
    for char in ciphertext:
        # i等于i加1再模256
        i = (i + 1) % 256
        # j等于j加上S盒的第i个元素再模256
        j = (j + S[i]) % 256
        # 交换S盒的第i个元素和第j个元素
        S[i], S[j] = S[j], S[i]
        # 生成一个密钥流的字节，它等于S盒的第i个元素和第j个元素之和再模256对应的S盒的元素
        k = S[(S[i] + S[j]) % 256]
        # 将密文的字符和密钥流的字节进行异或运算，得到解密后的字符，并添加到out列表中
        out.append(chr(ord(char) ^ k))
    # 将out列表中的所有字符拼接起来，形成一个字符串，并返回
    return ''.join(out)

# 调用RC4解密函数，传入密钥和密文，得到明文
key = b'Scr1w666' # 这是一个示例密钥，您可以根据您的情况修改
eventext = b'\x07\x9B\xE8\xAC\x68\xAB\xAF\x3E\xC4\x66\xD1\x0E\x88\x06\x8A\x11' # 这是一个示例密文，您可以根据您的情况修改
oddtext  = b'\x93\xB1\x33\xA3\xC5\x40\x3B\xB5\xF9\x64\xDF\xEB\xD7\xA8\x24\x88'

eventext = rc4_decrypt(key, eventext)
oddtext = rc4_decrypt(key, oddtext)
# 打印明文
print(eventext)
print(oddtext)
#\x07\x93\x9B\xB1\xE8\x33\xAC\xA3\x68\xC5\xAB\x40\xAF\x3B\x3E\xB5\xC4\xF9\x66\x64\xD1\xDF\x0E\xEB\x88\xD7\x06\xA8\x8A\x24\x11\x88
