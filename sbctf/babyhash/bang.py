import subprocess
import itertools
# 要输入的字符串长度
input_length = 6

# 生成所有情况的6个字符的小写字符串
all_strings = itertools.product(
    'abcdefghijklmnopqrstuvwxyz', repeat=input_length)

for chars in all_strings:
    # 将元组转换为字符串
    input_string = ''.join(chars)
    # 启动子进程
    process = subprocess.Popen(["babyhash.exe"], stdin=subprocess.PIPE,
                               stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True)

    # 向子进程的标准输入发送字符串
    process.stdin.write(input_string)
    process.stdin.flush()  # 刷新缓冲区

    # 等待子进程完成，并获取输出
    output, error = process.communicate()

    # 打印输出和错误信息
    print("Input:", input_string)
    # 在这里添加检查成功信息的条件
    if "Wrong key!"not in output:
        print(f"Success! Input: {input_string}")
        break
