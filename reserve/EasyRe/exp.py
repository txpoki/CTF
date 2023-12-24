t=[i for i in b'xa3xd8xacxa9xa8xd6xa6xcdxd0xd5xf7xb7x9cxb31-@[K:xfdWB_XRTx1bx0cx9-xd9=5x1ftA@GBx11']
rbx=72
for i in range(len(t)-1,-1,-1):
   t[i]^=rbx
   rbx+=2
   rbx&=0xff
rbx=0
for i in range(len(t)-1,-1,-1):
   t[i]-=rbx
   t[i]+=0x100
   t[i]&=0xff
   rbx+=1
   rbx&=0xff
rbx=36
for i in range(len(t)-1,-1,-1):
   t[i]^=rbx
   rbx+=2
   rbx&=0xff
print(t)
print(bytes(t))