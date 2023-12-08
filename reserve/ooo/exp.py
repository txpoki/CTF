# 自定义的Base64字符集
custom_alphabet = 'ABCDFEGH1JKLRSTMNP0VWQUXY2a8cdefijklmnopghwxyqrstuvzOIZ34567b9+/'

# 要解码的字符串
encoded_str = '2aYcdfL2fS1BTMMF1RSeM TTASS1OJ8RHTJdBYJ2STJfNMSMAYcKUJddp'

# 将密文在密码表中对应的位置（从1开始计数）用六位二进制表示打印出来，并在每六个位置后面加一个空格
binary_str = ' '.join([format(custom_alphabet.index(c) , '06b') for c in encoded_str if c in custom_alphabet])
print(binary_str)
