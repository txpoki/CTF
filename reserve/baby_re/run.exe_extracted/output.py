from new import *
import re
enc='5WEU5ROREb0hK+AurHXCD80or/h96jqpjEhcoh2CuDh='
k=""
def check (t):
    k=t
    for a1 in a:
        for a2 in a:
            for a3 in a:
                t=t+a1+a2+a3
                pt = mmo(t)
                flag = pt()
                if enc.startswith(flag):
                    return t
                else:
                    t=k
def check2(t):
    k=t
    for a1 in a:
        for a2 in a:
                t=t+a1+a2
                pt = mmo(t)
                flag = pt()
                if enc.startswith(flag):
                    return t
                else:
                    t=k

t=""
a=list(set(word))
while(len(t)<len(enc)):
    t=check(t)
  
    if len(t)==30:
        t=check2(t)
        print(t)
        break


