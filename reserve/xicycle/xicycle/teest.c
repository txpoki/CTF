#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdint.h>

#define KEY_MAC "HmacMD5"
#define MOD 65537
#define ADD 65535
#define DELTA 0xA1A1A1A1
#define ROUNDS 32
#define KEY_LEN 50

// 定义一个密钥数组
    int key[56] = {
    12643, 25650, 12644, 13156, 13619, 25136, 13414, 14691, 25698, 51302, 51306, 26308, 24680, 52338,
    50786, 50888, 52624, 54477, 35008, 53656, 58764, 50573, 37064, 50576, 39697, 33187, 12747, 6539,
    6945, 37259, 8603, 8617, 18019, 38451, 5686, 17187, 5699, 13891, 21302, 8963, 26156, 27782, 17964,
    34412, 34470, 27718, 1676, 50988, 3212, 22796, 55565, 19672, 16582, 28874, 19287, 56017
    };

// 定义一个预设的字节数组
uint8_t preset[32] = {-26, -87, 15, -85, 76, 15, -107, -95, -72, -59, -60, 101, -80, -15, 117, 117, -58, -76, 60, 69, 53, -4, 123, -36, -45, -104, 98, -127, -63, 16, 83, -124};

// 定义一个加法变形函数
int add(int a, int b) {
    return (a + b) & ADD;
}

// 定义一个乘法变形函数
int mul(int a, int b) {
    long long c = (long long)a * b;
    return (c != 0 ? (int)(c % MOD) : (1 - a) - b) & ADD;
}

// 定义一个加密函数
void encrypt(uint8_t *bytes, int i) {
    int  j, k, t, s, s2, t2, t3, t4, s3;
        // 将每个块分别表示为i7, i10, i13, i16, t5, s4, s5, t6
        int i7 = (bytes[i + 0] << 8) | bytes[i + 1];
        int i10 = (bytes[i + 2] << 8) | bytes[i + 3];
        int i13 = (bytes[i + 4] << 8) | bytes[i + 5];
        int i16 = (bytes[i + 6] << 8) | bytes[i + 7];
        // 对每个块进行8轮的加密操作
        k = 0;
        for (j = 0; j < 8; j++) {
            t = mul(i7, key[k++]); // 对i7和key[k]进行乘法变形
            s = add(i10, key[k++]); // 对i10和key[k]进行加法变形
            s2 = add(i13, key[k++]); // 对i13和key[k]进行加法变形
            t2 = mul(i16, key[k++]); // 对i16和key[k]进行乘法变形
            t3 = mul(t ^ s2, key[k++]); // 对t和s2进行异或，然后和key[k]进行乘法变形
            t4 = mul(add(s ^ t2, t3), key[k++]); // 对s和t2进行异或，然后和t3进行加法变形，再和key[k]进行乘法变形
            s3 = add(t3, t4); // 对t3和t4进行加法变形
            i7 = t ^ t4; // 对t和t4进行异或，赋值给i7
            i10 = s2 ^ t4; // 对s2和t4进行异或，赋值给i10
            i13 = s ^ s3; // 对s和s3进行异或，赋值给i13
            i16 = t2 ^ s3; // 对t2和s3进行异或，赋值给i16
        }
        // 将加密后的块重新组合成一个新的bytes数组
        bytes[i + 0] = (uint8_t)(i7 >> 8);
        bytes[i + 1] = (uint8_t)i7;
        bytes[i + 2] = (uint8_t)(i10 >> 8);
        bytes[i + 3] = (uint8_t)i10;
        bytes[i + 4] = (uint8_t)(i13 >> 8);
        bytes[i + 5] = (uint8_t)i13;
        bytes[i + 6] = (uint8_t)(i16 >> 8);
        bytes[i + 7] = (uint8_t)i16;
    }

// 定义一个解密函数
void decrypt(uint8_t *bytes, int len,int i4,int i2) {
                if (i4 >= 20) {
                    int length = len/ 4;
                    int iArr2[8]={0};
                    int i29 = 0;
                    int i30 = 0;
                    while (i29 < length) {
                        iArr2[i29] = ((bytes[i30 + 2] & 255) << 8) | (bytes[i30 + 3] & 255) | ((bytes[i30 + 1] & 255) << 16) | ((bytes[i30 + 0] & 255) << 24);
                        i30 += 4;
                        i29++;
                    }
                    int i31 = (i4 / 4) - 2;
                    int i32 = i31 + 1;
                    int i33 = iArr2[i32];
                    for (int i34 = 0; i34 < 32; i34++) {
                        int i35 = 1;
                        while (i35 > 0) {
                            int i36 = (i2 >> 2) & 3;
                            int i37 = 1;
                            while (i37 > 0) {
                                int i38 = i31 + i37;
                                int i39 = iArr2[i38 - 1];
                                i25 = iArr2[i38] - ((((i39 >>> 5) ^ (i25 << 2)) + ((i25 >>> 3) ^ (i39 << 4))) ^ ((i2 ^ i25) + (iArr2[(i37 & 3) ^ i36] ^ i39)));
                                iArr2[i38] = i25;
                                i37--;
                            }
                            int i40 = iArr2[i32];
                            i25 = iArr2[i31] - ((((i40 >>> 5) ^ (i25 << 2)) + ((i25 >>> 3) ^ (i40 << 4))) ^ ((i2 ^ i25) + (iArr2[(i37 & 3) ^ i36] ^ i40)));
                            iArr2[i31] = i25;
                            i2 -= -158018577;
                            i35 = i37 - 1;
                        }
                    }
                    ByteBuffer allocate = ByteBuffer.allocate(length * 4);
                    allocate.asIntBuffer().put(iArr2);
                    bytes = allocate.array();
                } else {
                    iArr = iArr;
                }

    //int i, j, k, t, s, s2, t2, t3, t4, s3;
    //for (i = 0; i < len; i += 8) {
    //    // 将每个块分别表示为i7, i10, i13, i16, t5, s4, s5, t6
    //    int i7 = (bytes[i + 0] << 8) | bytes[i + 1];
    //    int i10 = (bytes[i + 2] << 8) | bytes[i + 3];
    //    int i13 = (bytes[i + 4] << 8) | bytes[i + 5];
    //    int i16 = (bytes[i + 6] << 8) | bytes[i + 7];
    //    // 对每个块进行8轮的解密操作
    //    k = 48;
    //    for (j = 0; j < 8; j++) {
    //        t4 = mul(add(i7, i10), key[k--]); // 对i7和i10进行加法变形，然后和key[k]进行乘法变形
    //        t3 = add(i13, i16); // 对i13和i16进行加法变形
    //        s3 = add(t3, t4); // 对t3和t4进行加法变形
    //        t2 = mul(i16 ^ s3, key[k--]); // 对i16和s3进行异或，然后和key[k]进行乘法变形
    //        s = mul(i10 ^ s3, key[k--]); // 对i10和s3进行异或，然后和key[k]进行乘法变形
    //        s2 = add(i13 ^ t4, key[k--]); // 对i13和t4进行异或，然后和key[k]进行加法变形
    //        t = mul(i7 ^ t4, key[k--]); // 对i7和t4进行异或，然后和key[k]进行乘法变形
    //        i7 = t; // 赋值给i7
    //        i10 = s; // 赋值给i10
    //        i13 = s2; // 赋值给i13
    //        i16 = t2; // 赋值给i16
    //    }
    //    // 将解密后的块重新组合成一个新的bytes数组
    //    bytes[i + 0] = (uint8_t)(i7 >> 8);
    //    bytes[i + 1] = (uint8_t)i7;
    //    bytes[i + 2] = (uint8_t)(i10 >> 8);
    //    bytes[i + 3] = (uint8_t)i10;
    //    bytes[i + 4] = (uint8_t)(i13 >> 8);
    //    bytes[i + 5] = (uint8_t)i13;
    //    bytes[i + 6] = (uint8_t)(i16 >> 8);
    //    bytes[i + 7] = (uint8_t)i16;
}

// 定义一个检查函数
void check(char *password) {
    int delta = 0;
    int len = strlen(password);
    if (len == 32) {
        // 将密码转换为字节数组
        uint8_t *bytes = (uint8_t *)password;
        for (int i = 0; i < 32;i+=8)
        {
            // 对字节数组进行加密
            encrypt(bytes, i);
            // 如果字节数组的长度大于20，对字节数组进行解密
            if (i >= 20)
            {
                decrypt(bytes, len,i,delta);
            }
        }
        // 将解密后的字节数组和预设的字节数组进行比较
        if (memcmp(bytes, preset, 32) == 0) {
            // 如果相等，显示right
            printf("right\n");
        } else {
            // 如果不相等，显示wrong
            printf("wrong\n");
        }
    } else {
        // 如果密码的长度不是32，显示wrong
        printf("wrong\n");
    }
}

// 定义一个主函数
int main() {
    // 设置布局为R.layout.activity_main
    // 省略
    // 获取用户输入的密码
    char password[32];
    scanf("%s", password);
    // 调用检查函数
    check(password);
    return 0;
}