#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// 将字节数组转换为整数数组
static int *method1(unsigned char *r0, int len) {
    int *r1 = (int *)malloc(len / 4 * sizeof(int));
    int i = 0, j = 0;

    while (j < len) {
        r1[i] = (r0[j + 3] & 0xFF) | ((r0[j + 2] & 0xFF) << 8) | ((r0[j + 1] & 0xFF) << 16) | (r0[j] << 24);
        i++;
        j += 4;
    }

    return r1;
}

// 将整数数组转换为字节数组
static unsigned char *method2(int *r0, int len) {
    unsigned char *r1 = (unsigned char *)malloc(len * 4 * sizeof(unsigned char));
    int i = 0, j = 0;

    while (j < len * 4) {
        r1[j + 3] = (unsigned char)r0[i];
        r1[j + 2] = (unsigned char)(r0[i] >> 8);
        r1[j + 1] = (unsigned char)(r0[i] >> 16);
        r1[j] = (unsigned char)(r0[i] >> 24);
        i++;
        j += 4;
    }

    return r1;
}

// 使用XXTEA加密算法解密字节数组
static unsigned char *method3(unsigned char *r0, int len, int *r3) {
    int *r1 = method1(r0, len);
    int i = 0;


    while (i < len / 4) {
        int j = 0;
        int k = 0;
for (int i = 0; i < 32; i++)
{
    k -= 1640531527;
}

        while (j < 32) {
            k += 1640531527;
            int m = (r1[i] << 4) + r3[0];
            int n = (r1[i] + k) ^ m;
            int o = (r1[i] >> 5) + r3[1];
            int p = n ^ o;
            r1[i+1] -= p; // 解密时，将加法改为减法
            int q = (r1[i+1] << 4) + r3[2];
            int r = (r1[i+1] + k) ^ q;
            int s = (r1[i+1] >> 5) + r3[3];
            int t = r ^ s;
            r1[i] -= t; // 解密时，将加法改为减法
            j++;
        }

        i += 2;
    }

    unsigned char *result = method2(r1, len / 4);
    free(r1);
    return result;
}

// 将一个字节转换为一个正整数
static int method4( char b0) {
 int i=(b0 < 0) ? -b0: b0;
 return i;
}

int main() {
    int r0[] = { 1732584193, -271733879, -1732584194, 271733878 };

   
    unsigned char r7[] = { 73, -65, 27, -19, -77, 28, 108, 82, 43, 60, -14, 58, 28, 44, -21, 77, 31, 114, 43, 98, 88, 17, 23, -9 };

    int len = 24;
    unsigned char *r16 = (unsigned char *)r7;

    unsigned char *decrypted = method3(r16, len, r0); // 调用解密函数

    printf("decrypted flag:\n");
    for (int i = 0; i < len; i++) {
        printf("%c", method4(decrypted[i])); // 输出解密后的flag
    }
    printf("\n");

    free(decrypted);
    return 0;
}
