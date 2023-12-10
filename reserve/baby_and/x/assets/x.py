# 导入所需的模块
import binascii
import os

# 定义异或的密钥
key = b'71375A32'

# 定义输入和输出的文件名
input_file = 'input.jpg'
output_file = 'output.jpg'

# 打开输入文件，以二进制模式读取
with open(input_file, 'rb') as f:
    # 读取文件内容，转换为16进制字符串
    hex_data = binascii.hexlify(f.read())
    # 计算文件长度
    file_len = len(hex_data)
    # 初始化输出的16进制字符串
    output_hex = b''
    # 遍历文件内容，每四个字节为一组
    for i in range(0, file_len, 8):
        # 取出当前的四个字节
        chunk = hex_data[i:i+8]
        # 将其与密钥进行异或运算，得到异或后的四个字节
        xor_chunk = hex(int(chunk, 16) ^ int(key, 16))[2:].zfill(8)
        # 将异或后的四个字节追加到输出的16进制字符串中
        output_hex += xor_chunk.encode()
    # 将输出的16进制字符串转换为二进制数据
    output_data = binascii.unhexlify(output_hex)

# 打开输出文件，以二进制模式写入
with open(output_file, 'wb') as f:
    # 写入二进制数据
    f.write(output_data)

# 打印提示信息
print('Done! The output file is saved as', output_file)
