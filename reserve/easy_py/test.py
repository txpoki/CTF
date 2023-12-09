import time

def encode_1():
    global num
  
    flag[num] = flag[num] ^ num
    num -= 1

def encode_2():
    global num
    flag[num] = flag[num] ^ flag[(num + 1)]
    num -= 1

while True:
    Happy = [44, 100, 3, 50, 106, 90, 5, 102, 10, 112]# He110_cazy
 #                *      *         *      *         *
 #
    num = 9
    f = input('Please input your flag:')
    
    if len(f) != 10:
        print('Your input is illegal')
    else:
        flag = list(map(ord, f))
        print("flag to 'ord':", flag)

        # Loop to execute encode_1 and encode_2 alternately until num < 0
        while num >= 0:
            encode_1()
            encode_2()

        if flag == Happy:
            print('Good job!')
        else:
            print('No no no!')

