import random
flag = 'xxxxxxxxxxxxxxxxxxxx'
random.seed(1)
l = []
for i in range(4):
    l.append(random.getrandbits(8))
result = [201, 8, 198, 68, 131, 152, 186, 136, 13, 130, 190, 112, 251, 93, 212, 1, 31, 214, 116, 244]
result1 =[]
for i in range(len(l)):
    random.seed(l[i])
    for n in range(5):
        result1.append(result[i*5+n]^random.getrandbits(8))
print(result1)
