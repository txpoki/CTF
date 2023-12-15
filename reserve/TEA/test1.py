from z3 import *

def decrypt_round(a4, a5, v9_known, v6_known):
    s = Solver()

    # 声明 Z3 变量
    v9 = BitVec('v9', 32)
    v6 = BitVec('v6', 32)

    # 约束 v9 和 v6 的值
    s.add(v9 == v9_known)
    s.add(v6 == v6_known)
   
    # 为 a4 数组声明 Z3 变量
    a4_vars = [BitVec(f'a4_{i}', 32) for i in range(8)]

    s.add(a4_vars[7] == a4[7])
    s.add(a4_vars[0] + ((a4_vars[7] ^ v9) + (a4_vars[6] ^ a5[x])) ^ (((a4_vars[0] << 2) ^ (a4_vars[6] >> 5)) + ((a4_vars[0] >> 3) ^ (a4_vars[6] << 4))) == a4[0])

    # 每轮的约束条件
    for i in range(7):
        x = (v6_known ^ i) & 3
        s.add(a4_vars[i] == a4[i])
        s.add(a4_vars[i + 1] == a4[i + 1])
        s.add(a4_vars[i] + ((a4_vars[i + 1] ^ v9) + (a4_vars[7] ^ a5[x])) ^ (((a4_vars[i + 1] << 2) ^ (a4_vars[7] >> 5)) + ((a4_vars[i + 1] >> 3) ^ (a4_vars[7] << 4))) == a4[i])


    # 检查约束条件是否满足
    if s.check() == sat:
        m = s.model()
        v9_result = m[v9].as_long()
        v6_result = m[v6].as_long()

        # 返回结果
        return v9_result, v6_result
    else:
        return None

# 示例用法:
a4 = [0xb047aa9b, 0xe99dc532, 0x633d363f, 0x8f5c80c3, 0xee875187, 0xb1906477, 0xfd6d416b, 0x3a5e1ccd]
a5 = [0x666C, 0x6167, 0x7A61, 0x5556]  # 对应 "lf", "ga", "a", "{"

v9_known =0
# 已知的 v9 和 v6 的值
#for i in 12:
    #if i == 0:
        #v9_known=0x6a99b4ac
    #else:
        #v9_known += 0x61C88647
    #v6_known = (v9_known >> 2) & 3
    ## 解密一轮
    #result = decrypt_round(a4, a5, v9_known, v6_known)
    #print(result)
v9_known=0x6a99b4ac
v6_known = (v9_known >> 2) & 3
result = decrypt_round(a4, a5, v9_known, v6_known)
print(result)