#include <stdio.h>
#include <stdint.h>

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

int main() {
    uint32_t k[4] = { 1732584193, -271733879, -1732584194, 271733878 };
    uint32_t sou[24] = { 73, -65, 27, -19, -77, 28, 108, 82, 43, 60, -14, 58, 28, 44, -21, 77, 31, 114, 43, 98, 88, 17, 23, -9 };

    // 将 sou 数组转换为两个 32 位整数
    uint32_t v[2];
    uint32_t tt=sou[1] & 0xFF;
    v[0] = (sou[0] << 24) | ((sou[1] & 0xFF) << 16) | ((sou[2] & 0xFF) << 8) | (sou[3] & 0xFF);
    v[1] = (sou[4] << 24) | ((sou[5] & 0xFF) << 16) | ((sou[6] & 0xFF) << 8) | (sou[7] & 0xFF);

    // 打印解密前的值
    printf("Before Decryption:\n");
    printf("v[0]: %x\n", v[0]);
    printf("v[1]: %x\n", v[1]);

    // 使用 TEA 解密
    teaDecrypt(v, k);

    // 打印解密后的值
    printf("\nAfter Decryption:\n");
    printf("v[0]: %x\n", v[0]);
    printf("v[1]: %x\n", v[1]);

    return 0;
}
