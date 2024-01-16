#include <stdio.h>
#include <stdint.h>

//加密函数
void encrypt(uint32_t* v, uint32_t* k) {
	uint32_t v0 = v[0], v1 = v[1], sum = 0, i;
	uint32_t delta = 0x9e3779b9;//Delta
	uint32_t k0 = k[0], k1 = k[1], k2 = k[2], k3 = k[3];
	for (i = 0; i < 32; i++) {//
		sum += delta;
		v0 += ((v1 << 4) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
		v1 += ((v0 << 4) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
	}
	v[0] = v0; v[1] = v1;
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

int main()
{
	// v为要加解密的数据，两个32位的数据
    uint8_t sou[24] ;
        sou[0] = 73;
        sou[1] = -65;
        sou[2] = 27;
        sou[3] = -19;
        sou[4] = -77;

        sou[5] = 28;

        sou[6] = 108;

        sou[7] = 82;

        sou[8] = 43;

        sou[9] = 60;

        sou[10] = -14;

        sou[11] = 58;

        sou[12] = 28;

        sou[13] = 44;

        sou[14] = -21;

        sou[15] = 77;

        sou[16] = 31;

        sou[17] = 114;

        sou[18] = 43;

        sou[19] = 98;

        sou[20] = 88;

        sou[21] = 17;

        sou[22] = 23;

        sou[23] = -9;
    uint32_t v[2] = { 1,2 };
	// k为加解密密钥，4个32位无符号整数，密钥长度为128位
	uint32_t k[4] = { 1,2,3,4 };
        k[0] = 1732584193;
        k[1] = -271733879;
        k[2] = -1732584194;
        k[3] = 271733878;

        for (int j=0; j < 3;j++)
        {

            v[0] = (unsigned int)sou[j * 8] << 24 | (unsigned int)sou[j * 8 + 1] << 16 | (unsigned int)sou[j * 8 + 2] << 8 | (unsigned int)sou[j * 8 + 3];
            v[1] = (unsigned int)sou[j * 8+4] << 24 | (unsigned int)sou[j * 8 + 5] << 16  | (unsigned int)sou[j * 8 + 6] << 8 | (unsigned int)sou[j * 8 + 7];

            int n = sizeof(v) / sizeof(uint32_t);
            decrypt(v, k);
            printf("解密后的数据：0x%x 0x%x\n", v[0], v[1]);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < sizeof(uint32_t) / sizeof(uint8_t); j++)
                {
                    printf("%c", (v[i] >> (j * 8)) & 0xFF);
                }
            }
        }
    printf("\n");
	return 0;
}
