#include <stdio.h>
#include <stdint.h>
#define DELTA 0x9e3779b9
#define MX (((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (key[(p & 3) ^ e] ^ z)))

void encrypt(uint32_t *v, int n, uint32_t const key[4])
{
    uint32_t y, z, sum;
    unsigned p, rounds, e;
    // 加密

    rounds = 6 + 52 / n; // rounds的值是6 + 52 / n的原因是，这个公式可以在不同的数据长度下，保持速度和安全的平衡。
    sum = 0;
    z = v[n - 1];
    do
    {
        sum += DELTA;
        e = (sum >> 2) & 3; // e的值会影响加密或解密中的混合运算，即MX的定义。
        for (p = 0; p < n - 1; p++)
        {
            y = v[p + 1];
            z = v[p] += MX;
        }
        y = v[0];
        z = v[n - 1] += MX;
    } while (--rounds);

    // 解密
}
void decrypt(uint32_t *v, int n, uint32_t const key[4])
{
    uint32_t y, z, sum;
    unsigned p, rounds, e;

    rounds = 9;
    sum = rounds * DELTA; // 可以通过轮数求出每轮的DELTA
    y = v[0];
    do
    {
        e = (sum >> 2) & 3;         // 可以通过每轮的DELTA求出每轮的e
        for (p = n - 1; p > 0; p--) // 解密就是加密的逆运算
        {
            z = v[p - 1];
            y = v[p] -= MX;
        }
        z = v[n - 1];
        y = v[0] -= MX;
        sum -= DELTA;
    } while (--rounds);
}

int main()
{

    uint32_t v[12] = {0x3770E52D,0xAC07F92,0xECC8FFF3,0xA0E26317,0x1E0E43DC,0x8034A680,0xAA0DB403,0xFA341902,0x46DF4060,0xF82E22B4,0xE1D25B0A,0x5C419F7};
    // k为加解密密钥，4个32位无符号整数，密钥长度为128位
    uint32_t k[4] = {0x11,0x22,0x33,0x44};

    // n的绝对值表示v的长度，取正表示加密，取负表示解密
    int n = sizeof(v) / sizeof(uint32_t);

    decrypt(v, n, k);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < sizeof(uint32_t) / sizeof(uint8_t); j++)
        {
            printf("%02x ", (v[i] >> (j * 8)) & 0xFF);

        }
    }
    printf("\n");
    return 0;
}

