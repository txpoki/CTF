from new import *
import re
enc='5WEU5ROREb0hK+AurHXCD80or/h96jqpjEhcoh2CuDh='
a=list(set(word))

for a1 in a:
    for a2 in a:
        for a3 in a:
            t="8b98aa"+a1+a2+a3
            pt = mmo(t)
            flag = pt()
            if enc.startswith(flag):
                print(t)

