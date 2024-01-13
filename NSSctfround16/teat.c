#include <stdio.h>
#include <stdint.h>
const uint64_t magic_number = 0x9E3779B9;

//加密函数
void encrypt(unsigned int num_rounds, uint32_t v[2], uint32_t const key[4]) {
	unsigned int i;
	uint32_t v0 = v[0], v1 = v[1], sum = 0, delta = 0x9E3779B9;
	for (i = 0; i < num_rounds; i++) {
		v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3]);
		sum += delta;
		v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3]);
	}
	v[0] = v0; v[1] = v1;
}

//解密函数
void decrypt(uint64_t *left, uint64_t *right, uint64_t *key) {
    // 初始化一个累加变量，它是魔数乘以32
    uint64_t sum = magic_number * 32;
    // 循环32次，对每一次进行解密操作
    for (int i = 0; i < 32; i++) {
        // 根据XTEA算法的公式，对右半部分进行减法操作，得到新的右半部分
        *right -= (((*left << 4) ^ (*left >> 5)) + *left) ^ (sum + key[(sum >> 11) & 3]);
        // 对累加变量进行减法操作，得到新的累加变量
        sum -= magic_number;
        // 根据XTEA算法的公式，对左半部分进行减法操作，得到新的左半部分
        *left -= (((*right << 4) ^ (*right >> 5)) + *right) ^ (sum + key[sum & 3]);
    }
    int gg = 1;
}
int main()
{
	// v为要加解密的数据，两个32位无符号整数
    uint64_t v[8] = { 0xc60b34b2bff9d34a, 0xf50af3aa8fd96c6b, 0x680ed11f0c05c4f1, 0x6e83b0a4aaf7c1a3, 0xd69b3d568695c3c5, 0xa88f4ff50a351da2, 0x5cfa195968e1bb5b, 0xc4168018d92196d9 };
	// k为加解密密钥，4个32位无符号整数，密钥长度为128位
    uint64_t k[4] = { 0x57656c636f6d6520, 0x746f204e53534354, 0x4620526f756e6423, 0x3136204261736963 };
	unsigned int r = 32;
    for(int i = 0; i < 8; i += 2) {
        // 定义两个64位无符号整数，用来存储左半部分和右半部分的值
        uint64_t left, right;
        // 从加密后的数据中获取左半部分和右半部分的值
        left = v[i];
        right = v[i + 1];
    decrypt(&left, &right, k);
        // 调用解密函数，对左半部分和右半部分进行解密
	
}
}