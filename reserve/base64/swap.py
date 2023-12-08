def swap_middle_chars(s):
    # 将字符串分成四个字符的块
    chunks = [s[i:i+4] for i in range(0, len(s), 4)]
    # 对每个块进行处理
    for i in range(len(chunks)):
        # 如果块的长度不足4个字符，就跳过
        if len(chunks[i]) < 4:
            continue
        # 交换中间两个字符
        chunks[i] = chunks[i][:1] + chunks[i][2] + chunks[i][1] + chunks[i][3:]
    # 将处理后的块连接成一个字符串
    return ''.join(chunks)

# 测试
s = "PncXPjtYODNbDHZVCDNVS1pVP5MpU4IX85Iz"
print(swap_middle_chars(s))
