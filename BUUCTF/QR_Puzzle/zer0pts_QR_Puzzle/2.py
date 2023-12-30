res = []
for line in open('key', 'r').readlines():
    line = line[:-1]
    res.append(line)
result = "\n".join(res[::-1])
open("invkey", 'w').write(result)