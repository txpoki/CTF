class BrainFuck:
    def __init__(self, aCode=""):
        self.code = aCode
        self.x = 0
        self.i = 0

    def run_code(self, aCode=""):
        if not aCode == "":
            self.code = aCode
        outputbuffer = ""
        self.code = BrainFuck.parse_code(self)
        blocks = BrainFuck.parse_blocks_in_code(self)
        char_buffer = {0: 0}
        while self.i < len(self.code):
            char_value = self.code[self.i]
            if char_value == ">":
                self.x += 1
                char_buffer.setdefault(self.x, 0)
            elif char_value == "<":
                self.x -= 1
            elif char_value == "+":
                char_buffer[self.x] += 1
            elif char_value == "-":
                char_buffer[self.x] -= 1
            elif char_value == ".":
                outputbuffer += chr(char_buffer[self.x])
            elif char_value == ",":
                char_buffer[self.x] = int(0)
            elif char_value == "[":
                if not char_buffer[self.x]:
                    self.i = blocks[self.i]
            elif char_value == "]":
                if char_buffer[self.x]:
                    self.i = blocks[self.i]
            self.i += 1

        return outputbuffer

    def parse_code(self):
        return "".join(c for c in self.code if c in "><+-.,[]")

    def parse_blocks_in_code(self):
        blocks = {}
        block_start_array = []
        for i in range(len(self.code)):
            if self.code[i] == "[":
                block_start_array.append(i)
            elif self.code[i] == "]":
                blocks[i] = block_start_array[-1]
                blocks[block_start_array.pop()] = i
        return blocks


hashlib = __import__("hashlib")
md5 = lambda x: hashlib.md5(x.encode()).hexdigest()
similarity = lambda x, y: sum([1 if i == j else 0 for i, j in zip(x, y)]) / len(x) * 100
print(
    """                 .-.                _        .--.                 
                 : :               :_;      : .-'                 
 .--. .---.      : `-. .--.  .--.  .-.,-.,-.: `;.-..-..---. .---. 
' '_.'`-'_.'     ' .; :: ..'' .; ; : :: ,. :: : : :; :`-'_.'`-'_.'
`.__.'`.___;_____`.__.':_;  `.__,_;:_;:_;:_;:_; `.__.'`.___;`.___;
           :_____:                                               
Welcome to ez_brainfuzz
You should write a code in brainfuck that outputs a specified string.
"""
)

FLAG = open("flag", "r").read()
target = md5(FLAG)
try:
    while True:
        code = input(">>> ")
        res = BrainFuck(code).run_code()
        sim = similarity(target, res)
        if sim == 100:
            print(f"Good Job! flag is {FLAG}")
        else:
            print(f"Now similarity: {int(sim)}%")
except Exception as e:
    exit(0)
