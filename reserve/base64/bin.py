def char_to_index_binary(s, table):
    # 初始化结果列表
    result = []
    # 遍历字符串中的每个字符
    for c in s:
        # 找到字符在字符表中的索引
        index = table.index(c)
        # 将索引转换为二进制，并去掉前面的'0b'
        binary = bin(index)[2:]
        # 将二进制数补齐到6位
        binary = '0' * (6 - len(binary)) + binary
        # 将二进制数添加到结果列表
        result.append(binary)
    # 将结果列表中的二进制数连接成一个字符串
    return ''.join(result)

# 测试
s = "PcnXPtjYONDbDZHVCNDVSp1VPM5pUI4X8I5z"
table = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+/"
print(char_to_index_binary(s, table))
