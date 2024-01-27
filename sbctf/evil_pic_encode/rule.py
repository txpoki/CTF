# Define your own print function in globals
def custom_print(value):
    print(value)

# Define a class C in globals
class C:
    pass

# Your expression should evaluate to 50
expression_result = 50

# Your expression should contain an addition
expression_addition = 20 + 30

# Your expression should contain a comprehension
expression_comprehension = sum(i for i in range(50))

# Time for some debugging, make sure your expression calls print
custom_print(expression_result)

# Oops, I committed my password(password.txt)
# (Assuming password is stored in a variable called 'password')
password = "your_password_here"

# Your expression should not contain... numbers
# Let's use variables instead of numbers in the expression
num1 = 20
num2 = 30
expression_no_numbers = num1 + num2

# Sorry, no builtins
# Avoid using built-in functions in your expression
expression_no_builtins = expression_result

# Your expression should not contain [
# Avoid using square brackets in your expression
expression_no_square_brackets = expression_result

# Create Rule instances
rules = [
    Rule("Your expression should evaluate to 50", expression_result == 50),
    Rule("Your expression should contain an addition", "+" in code),
    Rule("Your expression should contain a comprehension", "for" in code),
    Rule("Time for some debugging, make sure your expression calls print", "print" in code),
    Rule("That won't cut it, define your own print function in globals", "custom_print" in code),
    Rule("This is getting messy, maybe OOP will solve it, define a class C in globals", "class C" in code),
    Rule("Oops, I committed my password(password.txt)", "password" not in code),
    Rule("Your expression should not contain... numbers", "num1" in code or "num2" in code),
    Rule("Sorry, no builtins", "builtins" not in code),
    Rule("Your expression should not contain [", "[" not in code),
]

# Use RuleEvaluator to evaluate the rules
try:
    evaluator = RuleEvaluator(code, rules)
except Exception as e:
    print(f"Something went wrong: {e}")
    exit(1)

# Check if all rules are satisfied
if all(rule.ok for rule in evaluator.rules):
    from flag import FLAG
    print(f"You did it! The flag is {FLAG}")
else:
    missed = [rule for rule in evaluator.rules if not rule.ok]
    print("You missed some rules:")
    for rule in missed:
        print(f"- {rule.text}")
