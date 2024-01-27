d = {'a': 1, 'b': 2, 'c': 3, 'd': 4, 'e': 5, 'f': 6, 'g': 7, 'h': 8, 'i': 9, 'j': 10}

def print(x):
    global d 
    s = 'The result is ' + str(x)
  
    __builtins__.print(s)

class C:
    def __init__(self, x):
        self.x = x

c = C([d['a'] + d['b'] for i in range(d['e'])])

print(eval(''.join([str(i) for i in c.x])))
