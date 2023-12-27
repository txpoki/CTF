# 导入正则表达式模块
import re
# 定义要搜索的文本
f = open("test.txt", "r")
text = f.read()
# 定义要匹配的模式
f.close
pattern = r"32h\n(.*?),|32h,(.*?),|32h,(.*?)\n"
# 使用finditer方法返回一个迭代器
result = re.finditer(pattern, text)
# 遍历迭代器，获取每个匹配的内容和位置
for match in result:
    # 获取匹配的内容
    content = match.group()

    # 获取匹配的起始位置
    start = match.start()
    # 获取匹配的结束位置
    end = match.end()
    content = content.replace("\n",",")
    content= content.replace("32h,","")
    # 输出结果
    print(f"{content}",end="")
