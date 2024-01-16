#include <stdio.h>
#include <stdint.h>
#include <string.h>

// TEA解密函数
void teaDecrypt(uint32_t* v, uint32_t* k) {
    uint32_t v0 = v[0], v1 = v[1];
    uint32_t sum = 0xC6EF3720;
    uint32_t delta = 0x9e3779b9;

    for (int i = 0; i < 32; i++) {
        v1 -= ((v0 << 4) + k[2]) ^ (v0 + sum) ^ ((v0 >> 5) + k[3]);
        v0 -= ((v1 << 4) + k[0]) ^ (v1 + sum) ^ ((v1 >> 5) + k[1]);
        sum -= delta;
    }

    v[0] = v0;
    v[1] = v1;
}

// 方法1：将byte数组转换为int数组
int* method1(byte* r0, int* r1) {
    int i, j;
    for (i = 0, j = 0; j < 24; i++, j += 4) {
        r1[i] = (r0[j] & 0xFF) | ((r0[j + 1] & 0xFF) << 8) | ((r0[j + 2] & 0xFF) << 16) | ((r0[j + 3] & 0xFF) << 24);
    }
    return r1;
}

// 方法2：将int数组转换为byte数组
byte* method2(int* r0, byte* r1) {
    int i, j;
    for (i = 0, j = 0; j < 16; i++, j += 4) {
        r1[j] = (byte)(r0[i] & 0xFF);
        r1[j + 1] = (byte)((r0[i] >> 8) & 0xFF);
        r1[j + 2] = (byte)((r0[i] >> 16) & 0xFF);
        r1[j + 3] = (byte)((r0[i] >> 24) & 0xFF);
    }
    return r1;
}

int main() {
    uint32_t k[4] = { 1732584193, -271733879, -1732584194, 271733878 };
    byte sou[24] = { 73, -65, 27, -19, -77, 28, 108, 82, 43, 60, -14, 58, 28, 44, -21, 77, 31, 114, 43, 98, 88, 17, 23, -9 };

    int v[2];
    method1(sou, v);

    // 打印解密前的值
    printf("Before Decryption:\n");
    printf("v[0]: %d\n", v[0]);
    printf("v[1]: %d\n", v[1]);

    // 使用 TEA 解密
    teaDecrypt(v, k);

    // 打印解密后的值
    printf("\nAfter Decryption:\n");
    printf("v[0]: %d\n", v[0]);
    printf("v[1]: %d\n", v[1]);

    byte result[16];
    method2(v, result);

    // 打印解密后的字节数组
    printf("\nDecrypted Bytes:\n");
    for (int i = 0; i < 16; i++) {
        printf("%d ", result[i]);
    }

    return 0;
}
