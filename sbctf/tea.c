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
	//printf("解密后的数据：0x%x 0x%x\n", v0, v1);
	}
	v[0] = v0; v[1] = v1;
}

int main()
{
	// v为要加解密的数据，两个32位的数据
	uint32_t v[2] = {0x53424354,0x467b6161};
	// k为加解密密钥，4个32位无符号整数，密钥长度为128位
	uint32_t k[4] = { 1732584193, -271733879, -1732584194, 271733878 };
	int n = sizeof(v) / sizeof(uint32_t);
	encrypt(v, k);
	printf("加密后的数据：0x%x 0x%x\n", v[0], v[1]);
	decrypt(v, k);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < sizeof(uint32_t)/sizeof(uint8_t); j++)
		{
			printf("%c", (v[i] >> (j * 8)) & 0xFF);
		}
	}
	printf("\n");
	return 0;
}