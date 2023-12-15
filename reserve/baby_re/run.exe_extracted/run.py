# Visit https://www.lddgo.net/string/pyc-compile-decompile for more information
# Version : Python 3.7

from new import *
print('welcome!!!')
flag_input = input('please input flag:')
if set(word) >= set(flag_input):
    pt = mmo(flag_input)
    flag = pt()
    if flag == '5WEU5ROREb0hK+AurHXCD80or/h96jqpjEhcoh2CuDh=':
        print('right!!!')
        print('your flag: flag{' + flag_input + '}')
    else:
        print('Error')
else:
    print('please input again!')
