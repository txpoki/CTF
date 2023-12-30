from z3 import *

# Create BitVecs
a1 = BitVec('a1', 64)
a2 = BitVec('a2', 64)

# Create a solver
solver = Solver()

# Add the equations to the solver
solver.add(a1 == 2335067781)
solver.add(a1 == a2 ^ (a2 >> 18))

# Check for a solution
check_result = solver.check()

if check_result == sat:
    # If a solution exists, get the solution
    model = solver.model()

    # Get the values of the variables in the solution
    a1_value = model[a1]
    a2_value = model[a2]

    # Print the solution
    print("Solution found:")
    print("a1 =", a1_value)
    print("a2 =", a2_value)
else:
    print("No solution")
