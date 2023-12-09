# 导入hashlib模块
import hashlib

# 定义一个字符串
str1 = "ssssddssaassddddwwwwddwwddddddwwddddddssddwwddddddddssssaawwaassaassaassddssaassaawwwwwwaaaaaaaassaassddddwwddssddssssaassddssssaaaaaawwddwwaawwwwaassssssssssssddddssddssddddddddwwaaaaaawwwwddssddwwwwwwwwddssddssssssssddddss"

# 创建一个md5对象
md5 = hashlib.md5()

# 将字符串转换为字节并更新md5对象
md5.update(str1.encode())

# 获取md5的十六进制摘要
md5_hex = md5.hexdigest()

# 打印结果
print(md5_hex)
