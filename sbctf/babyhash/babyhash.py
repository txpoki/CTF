import angr, monkeyhex, claripy
proj = angr.Project('t/babyhash.exe')
flag_chars = [claripy.BVS('flag_%d' % i, 8) for i in range(6)]
flag=claripy.Concat(flag_chars+[claripy.BVV(b'\x00')])
state = proj.factory.call_state(0x1400D1DE0)
input_addr = 0

@proj.hook(0x1400D1E88, length=5)
def get_input(state):
    global input_addr
    input_addr = state.regs.rdx+8
    state.memory.store(input_addr,flag)
    print('Input done')

@proj.hook(0x1400D1E69, length=5)
def printf(state):
        return

simgr = proj.factory.simgr(state)
simgr.explore(find=0x1400D2014, avoid=0x1400D1FF2)
x=simgr.found[0].solver.eval(flag).to_bytes(6,"big")
print(x)
