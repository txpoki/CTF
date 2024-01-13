# 导入re模块，用来使用正则表达式
import re
# 导入sys模块，用来获取命令行参数
import sys


# 定义一个函数，用来从一个文件中提取匹配的字符串
# 参数是一个文件名，它是一个字符串
def extract_from_file(filename):
    # 定义一个正则表达式，用来匹配 val (任意运算符) (任意64位16进制数字)的字符串
    pattern = re.compile("val [^\n]+")
    # 打开文件，以只读模式

    with open(filename, "r",encoding="utf-8") as file:
        # 读取文件的内容，存储为一个字符串
        content = file.read()
        # 在文件内容中查找所有匹配的字符串，返回一个列表
        matches = pattern.findall(content)
        # 如果列表不为空，说明找到了匹配的字符串
        if matches:
            # 循环遍历列表，输出每个匹配的字符串
            for match in matches:
                print("val=",match)
        # 否则，说明没有找到匹配的字符串
        else:
            # 输出提示信息
            print("No match found in the file.")

# 如果这个文件是作为主程序运行，就调用这个函数
if __name__ == "__main__":
    
   
        filename = "Program.txt"
        # 调用这个函数，传递文件名
        extract_from_file(filename)
    # 否则，说明没有传递文件名

