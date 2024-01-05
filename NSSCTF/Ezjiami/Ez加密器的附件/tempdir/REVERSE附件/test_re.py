import angr, monkeyhex, claripy
proj = angr.Project('t/re_DASCTF1.exe')

#flag_chars = [claripy.BVS('flag_%d' % i, 8) for i in range(32)]
#flag = claripy.Concat(*[claripy.BVV(b'DASCTF{')]+flag_chars+[claripy.BVV(b'}\x00')])
flag_chars=[claripy.BVS('flag_%d' % i, 8) for i in range(6)]
flag = claripy.Concat(flag_chars+[claripy.BVV(b'\x00')])
state = proj.factory.call_state(0x1400140E0)
input_addr = 0

@proj.hook(0x140003C59, length=5)
def get_input(state):
    global input_addr
    input_addr = state.regs.rdx
    state.memory.store(input_addr,flag)
    print('Input done')

@proj.hook(0x140003C4E , length=5)
def printf(state):
        return
@proj.hook(0x140003C71 , length=5)
def printf(state):
        return

simgr = proj.factory.simgr(state)
simgr.explore(find=0x140003C6A )
x=simgr.found[0].solver.eval(flag).to_bytes(7,"big")
print(x)

