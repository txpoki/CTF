def decrypt(a4, a5):
    v7 = 12
    v9 = 0x6a99b4ac
    v10 = a4[6]

    while v7 > 0:
        v7 -= 1
        v6 = (v9 >> 2) & 3

        a4[7] -= ((a4[0] ^ v9) + (v10 ^ a5[(v6 ^ 6 & 3)])) ^ (((a4[0] << 2) ^ (v10 >> 5)) + ((a4[0] >> 3) ^ (v10 << 4)))

        for i in range(6, -1, -1):
            a4[i] -= ((a4[i + 1] ^ v9) + (v10 ^ a5[(v6 ^ i & 3)])) ^ (((a4[i + 1] << 2) ^ (v10 >> 5)) + ((a4[i + 1] >> 3) ^ (v10 << 4)))
            v10 = a4[i]

        v9 += 0x61C88647

    return a4

if __name__ == "__main__":
    a1 = "galfaaa{aaaaaaaaaaaaaaaaaaaa}aaa"
    a3 = "lf\x00\x00ga\x00\x00a{\x00\x00aa\x00\x00"

    a4 = [0] * 8
    a5 = [0] * 4

    for i in range(8):
        a4[i] = (ord(a1[4*i]) | ord(a1[4*i + 1]) << 8 | ord(a1[4*i + 2]) << 16 | ord(a1[4*i + 3]) << 24)

    for i in range(4):
        a5[i] = (ord(a3[4*i]) | ord(a3[4*i + 1]) << 8)

    decrypted_result = decrypt(a4, a5)
    print("解密结果:", [hex(val) for val in decrypted_result])
