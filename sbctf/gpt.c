#include <stdio.h>
#include <stdint.h>
static int method4( char b0) {
 int i=(b0 < 0) ? -b0: b0;
 return i;
}
//解密函数
void decrypt(uint32_t* v, uint32_t* k) {
    uint32_t v0 = v[0], v1 = v[1], sum = 0xC6EF3720, i;
    uint32_t delta = 0x9e3779b9;
    uint32_t k0 = k[0], k1 = k[1], k2 = k[2], k3 = k[3];
    for (i = 0; i<32; i++) {
        v1 -= ((v0 << 4) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
        v0 -= ((v1 << 4) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
        sum -= delta;
    }
    v[0] = v0; v[1] = v1;
}

int main() {
    // key为加解密密钥，4个32位无符号整数，密钥长度为128位
    uint32_t key[4] = { 1732584193, -271733879, -1732584194, 271733878 };
    // cipher为加密后的flag，24个字节，长度为6个32位无符号整数
    uint32_t sou[24] = {0x49,0xBF,0x1B,0xED,0xB3,0x1C,0x6C,0x52,0x2B,0x3C,0xF2,0x3A,0x1C,0x2C,0xEB,0x4D,0x1F,0x72,0x2B,0x62,0x58,0x11,0x17,0xF7};
    uint32_t cipher[6] = {0x49BF1BED,0xB31C6C52,0x2B3CF23A,0x1C2CEB4D,0x1F722B62,0x581117F7};
    // plain为解密后的flag，24个字节，长度为6个32位无符号整数
    uint32_t plain[6];
    // flag为解密后的flag，24个字符，长度为24个字节
    char flag[24];
    // 循环变量
    int i, j;
    // 对每两个32位无符号整数进行解密，得到plain
    for (i = 0; i < 6; i += 2) {
        decrypt(cipher + i, key);
        plain[i] = cipher[i];
        plain[i + 1] = cipher[i + 1];
    }
    // 将plain转换为flag，每个32位无符号整数转换为四个字符
    for (i = 0; i < 6; i++) {
        for (j = 0; j < 4; j++) {
            flag[i * 4 + j] = method4((plain[i] >> (j * 8)) & 0xFF);
        }
    }
    // 打印flag
    printf("The flag is: %s\n", flag);
    return 0;
}

