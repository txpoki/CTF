import angr, monkeyhex, claripy
proj = angr.Project('no_need_for_F5/main.exe')
flag_chars = [claripy.BVS('flag_%d' % i, 8) for i in range(32)]
flag = claripy.Concat(*[claripy.BVV(b'flag{')]+flag_chars+[claripy.BVV(b'}\x00')])
state = proj.factory.call_state(0x140001000)
input_addr = 0

@proj.hook(0x140001093, length=5)
def get_input(state):
    global input_addr
    input_addr = state.regs.rdx
    state.memory.store(input_addr,flag)
    print('Input done')

@proj.hook(0x140001079, length=5)
def printf(state):
    return

simgr = proj.factory.simgr(state)
simgr.explore(find=0x1400013A1, avoid=0x1400013B7)
simgr.found[0].solver.eval(flag).to_bytes(39,"big")