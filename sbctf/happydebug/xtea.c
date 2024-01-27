#include <stdio.h>
#include <stdint.h>

//加密函数
void encrypt(unsigned int num_rounds, uint32_t v[2], uint32_t const key[4]) {
	unsigned int i;
	uint32_t v0 = v[0], v1 = v[1], sum = 0, delta = 0x2222BCDF;
	for (i = 0; i < num_rounds; i++) {
		v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3]);
		sum += delta;
		v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3]);
        printf("0x%x\n",v1);
    }
	v[0] = v0; v[1] = v1;
}

//解密函数
void decrypt(unsigned int num_rounds, uint32_t v[2], uint32_t const key[4]) {
	unsigned int i;
	uint32_t v0 = v[0], v1 = v[1], delta =0x2222BCDF, sum = delta*num_rounds;
	for (i = 0; i < num_rounds; i++) {
		v1 -= (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3]);
		sum -= delta;
		v0 -= (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3]);
	}
	v[0] = v0; v[1] = v1;
}

int main()
{
	// v为要加解密的数据，两个32位无符号整数
	uint32_t v[2] = { 0xb8916dea, 0xb4676dec};
	// k为加解密密钥，4个32位无符号整数，密钥长度为128位
	uint32_t k[4] = {0x12d30f06 ,0xfdf514ec ,0x12e9b197, 0x61c7bbef };
	int n = sizeof(v) / sizeof(uint32_t);
	// num_rounds，建议取值为32
	unsigned int r = 46;
	decrypt(r,v, k);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < sizeof(uint32_t) / sizeof(uint8_t); j++)
		{
			printf("%c", (v[i] >> (j * 8)) & 0xFF);
		}
	}
	printf("\n");
	return 0;
}
