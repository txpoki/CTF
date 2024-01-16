import hashlib
import itertools

# 目标的 MD5 值
target_md5 = "f27d71f53ae17679fb352baa5ea326db"

# 要输入的字符串范围
alphabet = 'abcdefghijklmnopqrstuvwxyz'
input_length = 6  # xxxx 字符串的长度

# 生成所有情况的 6 个字符的小写字符串
all_strings = itertools.product(alphabet, repeat=input_length)

# 尝试每一个字符串
for chars in all_strings:
    input_string = '12345' + ''.join(chars) + '67890'
    
    # 计算 MD5 值
    md5_hash = hashlib.md5(input_string.encode()).hexdigest()

    # 检查是否匹配目标 MD5 值
    if md5_hash == target_md5:
        print("Success! Input:", input_string)
        break
