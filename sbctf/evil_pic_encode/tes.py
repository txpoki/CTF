# 定义一个字典，用字母代替数字
d = {'a': 1, 'b': 2, 'c': 3, 'd': 4, 'e': 5, 'f': 6, 'g': 7, 'h': 8, 'i': 9, 'j': 10}

# 定义一个自定义的 print 函数，用来打印结果
def print(x):
    global d # 引用全局变量 d
    # 把结果转换成字符串，用 + 号连接
    s = str(x)
    # 调用内置的 print 函数，打印 s
    __builtins__.print(s)

# 定义一个自定义的 C 类，用来创建一个对象
class C:
    # 定义一个构造函数，用来初始化对象的属性
    def __init__(self, x):
        self.x = x

# 创建一个 C 类的对象，传入一个元组推导式，生成一个元组
c = C((d['a'] + d['b'] for i in range(d['e'])))

# 用 eval 函数计算表达式的值，用自定义的 print 函数打印结果
print(eval(''.join([str(i) for i in c.x]) + '+d[\'e\']'))