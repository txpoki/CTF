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
    uint32_t k[4] = {0x67452301,0xEFCDAB89,0x98BADCFE,0x10325476};

    uint32_t sou[24] = {0x49,0xBF,0x1B,0xED,0xB3,0x1C,0x6C,0x52,0x2B,0x3C,0xF2,0x3A,0x1C,0x2C,0xEB,0x4D,0x1F,0x72,0x2B,0x62,0x58,0x11,0x17,0xF7};
    // 将 sou 数组转换为两个 32 位整数
    uint32_t v[2];
    for (int r = 0; r < 3; r++)
    {

        v[0] = (sou[r*8+0] << 24) | ((sou[r*8+1] & 0xFF) << 16) | ((sou[r*8+2] & 0xFF) << 8) | (sou[r*8+3] & 0xFF);
        v[1] = (sou[r*8+4] << 24) | ((sou[r*8+5] & 0xFF) << 16) | ((sou[r*8+6] & 0xFF) << 8) | (sou[r*8+7] & 0xFF);
        // 使用 TEA 解密
        teaDecrypt(v, k);
        // 打印解密后的值
        printf("%c%c%c%c%c%c%c%c",v[0]&0xFF,(v[0]>>8)&0xFF,(v[0]>>16)&0xFF,(v[0]>>24)&0xFF,v[1]&0xFF,(v[1]>>8)&0xFF,(v[1]>>16)&0xFF,(v[1]>>24)&0xFF);
        }
    return 0;
}


