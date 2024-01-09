from z3 import *

# Create Z3 integer variables
xorr = [Int(f'xorr_{i}') for i in range(4)]


flag = [178868, 188, 56953, 2413, 178874, 131, 56957, 2313, 178867, 156, 56933, 2377, 178832, 202, 56899, 2314, 178830, 167, 56924, 2313, 178830, 167, 56938, 2383, 178822, 217, 56859, 2372]
ans=[0]*55
# Create Z3 solver
solver = Solver()

# Add the equations to the solver
solver.add(xorr[0] * 256 - xorr[1] / 2 + xorr[2] * 23 + xorr[3] / 2 == 47118166)
solver.add(xorr[0] * 252 - xorr[1] * 366 + xorr[2] * 23 + xorr[3] / 2 - 1987 == 46309775)
solver.add(xorr[0] * 6 - xorr[1] * 88 + xorr[2] / 2 + xorr[3] / 2 - 11444 == 1069997)
solver.add((xorr[0] - 652) * 2 - xorr[1] * 366 + xorr[2] * 233 + xorr[3] / 2 - 13333 == 13509025)
solver.add(xorr[3]!=2360)
# Check if the solver is satisfiable
if solver.check() == sat:
    # Get the model with satisfying values
    model = solver.model()
    
    # Print the values
    print("Satisfying values:")
    for i in range(4):
        print(f"xorr[{i}] = {model[xorr[i]].as_long()}")
    result = [model[x].as_long() for x in xorr]
    result[3]=2361
    for i in range(len(flag)):
        ans[i] = flag[i] ^ result[(i % 4)]
    
    char_list = [chr(code) for code in ans]
    result_string = ''.join(char_list)
    print(result_string)

else:
    print("No satisfying values found.")
