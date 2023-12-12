#0011011001000111001100000011011100110100010010100101000000101011011100110010100101010111010101100011101001011010001010110101010000111100001001100010100001010001001100010011100001100000010010110111001100101001010101110101011000111010010110010011010001101000011100110011100101011011011010000011101001011001010000110101001100111111001001100011000001100000
#6G074JP+s)WV:Z+T<&(Q18`Ks)WV:Y4hs9[h:YCS?&0`
#010011100100001101010100010001100111101101001000001100000110110100110011010111110111001000110001011001000011000101101110001110010101111101101000001100000110110100110011010111110110010001111001001100010110111000111001010111110110100000110000011100000011001101111101
#NCTF{H0m3_r1d1n9_h0m3_dy1n9_h0p3}
enc="U>F2UsQXN`5sXMELT=:7M_2<X]^1ThaWF0=KM?9IUhAsTM5:T==_Ns&<Vhb!"
hisoralce="#$%&'()*+,-.s0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[h]^_`ab"
oralcehis="ba`_^]h[ZYXWVUTSRQPONMLKJIHGFEDCBA@?>=<;:9876543210s.-,+*)('&%$#"
# 定义字符串和字符表
string = "6G074JP+s)WV:Z+T<&(Q18`Ks)WV:Y4hs9[h:YCS?&0`"
char_table = "#$%&'()*+,-.s0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[h]^_`ab"

# 定义一个函数，将一个字符转换为6位二进制数
def char_to_bin (char):
    # 在字符表中查找字符的位置，如果找不到，返回空字符串
    index = char_table.find (char)
    if index == -1:
        return ""
    # 将位置转换为6位二进制数，不足6位的在前面补0
    bin_str = bin(index) [2:].zfill (6)
    return bin_str

# 定义一个函数，将一个字符串转换为6位二进制数的序列
def string_to_bin (string):
    # 创建一个空列表，用于存储每个字符的二进制数
    bin_list = []
    # 遍历字符串中的每个字符，调用char_to_bin函数，将结果添加到列表中
    for char in string:
        bin_list.append (char_to_bin (char))
    # 将列表中的元素用空格连接，返回一个字符串
    return "".join (bin_list)

# 调用string_to_bin函数，打印输出结果
print (string_to_bin (string))
