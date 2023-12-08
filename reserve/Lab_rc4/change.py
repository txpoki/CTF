
# 定义一个转换函数，它接受一个字节串作为参数，然后返回一个集合
def convert(s):
    # 初始化一个空列表，用于存储转换后的16进制数
    list = []
    # 遍历字节串的每个字节
    for char in s:
        # 将字节转换为0x开头的16进制数，并添加到列表中
        list.append(hex(char))
    # 将列表中的所有16进制数用逗号分隔，用花括号括起来，形成一个集合，并返回
    return "{" + ",".join(list) + "}"

# 调用转换函数，传入一个字节串，得到一个集合
s = b'\x93\xB1\x33\xA3\xC5\x40\x3B\xB5\xF9\x64\xDF\xEB\xD7\xA8\x24\x88'
result = convert(s)
# 打印结果
print(result)
