#include <stdio.h>
#include <stdint.h>
#define DELTA 0x9e3779b9
#define MX (((z>>5^y<<2) + (y>>3^z<<4)) ^ ((sum^y) + (key[(p&3)^e] ^ z)))

void encrypt(uint32_t *v, int n, uint32_t const key[4])
{
	uint32_t y, z, sum;
	unsigned p, rounds, e;
	//加密
	if (n > 1)
	{
		rounds = 6 + 52 / n;//rounds的值是6 + 52 / n的原因是，这个公式可以在不同的数据长度下，保持速度和安全的平衡。
		sum = 0;
		z = v[n - 1];
		do
		{
			sum += DELTA;
			e = (sum >> 2) & 3;//e的值会影响加密或解密中的混合运算，即MX的定义。
			for (p = 0; p < n - 1; p++)
			{
				y = v[p + 1];
				z = v[p] += MX;
			}
			y = v[0];
			z = v[n - 1] += MX;
		} while (--rounds);
	}
	//解密
}
void decrypt(uint32_t *v, int n, uint32_t const key[4]){
	uint32_t y, z, sum;
	unsigned p, rounds, e;

		rounds = 6 + 52 / n;
		sum = rounds*DELTA; //可以通过轮数求出每轮的DELTA
		y = v[0];
		do
		{
			e = (sum >> 2) & 3;//可以通过每轮的DELTA求出每轮的e
			for (p = n - 1; p>0; p--)//解密就是加密的逆运算
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
	
	uint32_t v[6] = {0x40cea5bc,0xe7b2b2f4, 0x129d12a9,0x5bc810ae, 0x1d06d73d,0xdcf870dc};
	// k为加解密密钥，4个32位无符号整数，密钥长度为128位
	uint32_t k[4] = { 1,2,3,4 };

	//n的绝对值表示v的长度，取正表示加密，取负表示解密
	int n = sizeof(v) / sizeof(uint32_t);

	printf("加密前原始数据:0x%x 0x%x\n", v[0], v[1]);
	encrypt(v, n, k);
	printf("加密后的数据:0x%x 0x%x\n", v[0], v[1]);
	decrypt(v, n, k);
	printf("解密后的数据:0x%x 0x%x\n", v[0], v[1]);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < sizeof(uint32_t) / sizeof(uint8_t); j++)
		{
			printf("%x", (v[i] >> (j * 8)) & 0xFF);
		}
	}
	printf("\n");
	return 0;
}
