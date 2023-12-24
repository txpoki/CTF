opcode=[17, 52, 0, 42, 5, 16, 20, 9, 23, 0, 36, 5, 3, 17, 29, 6, 0, 0, 5, 3, 17, 64, 6, 0, 72, 5, 17, 29, 23, 14, 1, 21, 4, 15, 1, 22, 2, 0, 0, 4, 3, 5, 16, 20, 50, 5, 9, 2, 19, 29, 5, 18, 21, 4, 16, 20, 61, 10, 1, 19, 52, 3, 4, 18, 14, 1, 21, 4, 7, 1, 22, 2, 0, 0, 4, 3, 5, 16, 20, 85, 5, 9, 1, 19, 64, 5, 18]
data=[0]*512
cnt=0
target=0
def sig_hand(sig:int,a1=None):
   global cnt
   s='unknown:{}'.format(sig)
   if sig==34:
       # data[esp++]=a1
       s='push {}'.format(a1)
   elif sig==35:
       s='pop {}'.format(a1)
   elif sig==36:
       s='add rax,rbx'
   elif sig==37:
       s='add {},{}'.format(a1,target)
   elif sig==38:
       s='sub rax,rbx'
   elif sig==39:
       s='sub {},{}'.format(a1,target)
   elif sig==40:
       s='xor rax,rbx'
   elif sig==41:
       s='test rax,rbx' # set flag
   elif sig==42:
       s='call {}'.format(target)
   elif sig==43:
       s='ret'
   elif sig==44:
       s='jmp {}'.format(target)
   elif sig==45:
       s='jz {}'.format(target)
   elif sig==46:
       s='push data[rcx]'
   elif sig==47:
       s='pop data[rcx]'
   elif sig==2:
       s='check'
   return s
ip_lst=[0,8,9,10,12,13,14,17,19,20]
while cnt<len(opcode):
   op=opcode[cnt]
   s='unknown'
   last_cnt=cnt
   cnt+=1
   if op in ip_lst:
       target=opcode[cnt]
       cnt+=1
   if op==0:
       s=sig_hand(34,target)
   elif op==1:
       s=sig_hand(34,'rax')
   elif op==2:
       s=sig_hand(34,'rbx')
   elif op==3:
       s=sig_hand(34,'rcx')
       pass
   elif op==4:
       s=sig_hand(35,'rax')
   elif op==5:
       s=sig_hand(35,'rbx')
   elif op==6:
       s=sig_hand(35,'rcx')
   elif op==7:
       s=sig_hand(36)
   elif op==8:
       s=sig_hand(37,'rax')
   elif op==9:
       s=sig_hand(37,'rbx')
   elif op==10:
       s=sig_hand(37,'rcx')
   elif op==11:
       s=sig_hand(38)
       pass
   elif op==12:
       s=sig_hand(39,'rax')
   elif op==13:
       s=sig_hand(39,'rbx')
   elif op==14:
       s=sig_hand(39,'rcx')
   elif op==15:
       s=sig_hand(40)
   elif op==16:
       s=sig_hand(41)
   elif op==17:
       s=sig_hand(42)
   elif op==18:
       s=sig_hand(43)
   elif op==19:
       s=sig_hand(44)
   elif op==20:
       s=sig_hand(45)
   elif op==21:
       s=sig_hand(46)
   elif op==22:
       s=sig_hand(47)
   else:
       s=sig_hand(2)
   print("%02d:%s"%(last_cnt,s))