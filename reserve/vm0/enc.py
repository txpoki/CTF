from z3 import*
def swap(a, b):
  a,b=b,a
  return a, b
bb=[105,  69,  42,  55,   9,  23, 197,  11,  92, 114,
   51, 118,  51,  33, 116,  49,  95,  51, 115, 114]
bb[15],bb[17]=swap(bb[15],bb[17])
bb[14],bb[18]=swap(bb[14],bb[18])
bb[19],bb[13]=swap(bb[19],bb[13])
 
s = Solver()
f = [BitVec(f"f{[i]}", 8) for i in range(11)]
 
 
s.add((f[6]*3+f[7]*2+f[8])*bb[12]==bb[6])
s.add(bb[12]*(f[7]*3+f[8]*2+f[9])==bb[7])
s.add(bb[12]*(f[8]*3+f[9]*2+f[10])==bb[8])
s.add(bb[0] == f[0] ^ f[1])
s.add(bb[1] == f[1] ^ f[2])
s.add(bb[2] == f[2] ^ f[3])
s.add(bb[3] == f[3] ^ f[4])
s.add(bb[4] == f[4] ^ f[5])
s.add(bb[5] == f[5] ^ f[6])
s.add(f[9]==bb[9])
s.add(f[10]==bb[10])
 
if s.check() == sat:
    t = s.model()
    for i in f:
        print(chr(t[i].as_long()), end='')
for i in range(0,9):
    print(chr(bb[11+i]),end="")
