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
    uint32_t k[4] = { 0x00000055, 0x0000016F, 0x000001E6, 0x000002A0};

unsigned int sou[32]={0x38,0x6a,0xd6,0x19,0x7d,0x71,0x90,0x6d,0x2a,0xb1,0xdd,0x12,0x8c,0x1b,0x8c,0xed,0xe1,0x65,0x4f,0x8a,0x9f,0x97,0xd6,0x23,0x62,0x10,0x39,0xc7,0xcb,0x62,0x3a,0x40};
    // 将 sou 数组转换为两个 32 位整数
    uint32_t v[2];
    for (int r = 0;r<4;r++)
    {

        v[0] = (sou[r*8+3] << 24) | ((sou[r*8+2] & 0xFF) << 16) | ((sou[r*8+1] & 0xFF) << 8) | (sou[r*8+0] & 0xFF);
        v[1] = (sou[r*8+7] << 24) | ((sou[r*8+6] & 0xFF) << 16) | ((sou[r*8+5] & 0xFF) << 8) | (sou[r*8+4] & 0xFF);

        // 打印解密前的值


        // 使用 TEA 解密
        teaDecrypt(v, k);

        // 打印解密后的值
        printf("%c%c%c%c%c%c%c%c",v[0]&0xFF,(v[0]>>8)&0xFF,(v[0]>>16)&0xFF,(v[0]>>24)&0xFF,v[1]&0xFF,(v[1]>>8)&0xFF,(v[1]>>16)&0xFF,(v[1]>>24)&0xFF);
        }
    return 0;
}

