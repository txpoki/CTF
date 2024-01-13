#include <stdio.h>
#include <stdint.h>
#include <string.h>

// 定义一个结构体，用来存储一个64位无符号整数和一个8位无符号整数数组的联合
typedef union {
    uint64_t val; // 64位无符号整数
    uint8_t bytes[8]; // 8位无符号整数数组，长度为8
} ZZZ;

// 定义一个函数，用来获取一个ZZZ结构体的val字段的值
uint64_t get_val(ZZZ z) {
    return z.val;
}

// 定义一个函数，用来设置一个ZZZ结构体的val字段的值
void set_val(ZZZ *z, uint64_t v) {
    z->val = v;
}

// 定义一个函数，用来获取一个ZZZ结构体的bytes字段的值
// 参数是一个指向ZZZ结构体的指针，返回值也是一个指向ZZZ结构体的指针
ZZZ *get_bytes(ZZZ *z) {
    // 不需要分配新的数组，直接返回原来的指针
    return z;
}

// 定义一个函数，用来设置一个ZZZ结构体的bytes字段的值
void set_bytes(ZZZ *z, uint8_t *b) {
    memcpy(z->bytes, b, 8);
}

// 定义一个常量，存储加密算法的魔数，它是一个64位无符号整数
// 这个魔数是由黄金分割比的倒数乘以2的32次方得到的，它是XTEA算法的一部分
const uint64_t magic_number = 0x9E3779B9;

// 定义一个函数，用来对一组数据进行解密
// 参数是两个指向64位无符号整数的指针，分别是左半部分和右半部分，以及一个指向64位无符号整数数组的指针，它是密钥
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
}

// 定义主函数，程序的入口点
int main() {
    // 定义一个数组，存储加密算法的密钥，每个元素是一个64位无符号整数
    // 这个密钥是由四个字符串转换成的十六进制数，分别是"Welcome ", "to NSSCTF", " Round#1", "6 Basic"
    uint64_t key[4] = { 0x57656c636f6d6520, 0x746f204e53534354, 0x4620526f756e6423, 0x3136204261736963 };

    // 定义一个数组，存储加密后的数据，每个元素是一个64位无符号整数
    // 这个数据是由一个字符串转换成的十六进制数，这个字符串就是要求输出的标志
    uint64_t encrypted_data[8] = { 0xc60b34b2bff9d34a, 0xf50af3aa8fd96c6b, 0x680ed11f0c05c4f1, 0x6e83b0a4aaf7c1a3, 0xd69b3d568695c3c5, 0xa88f4ff50a351da2, 0x5cfa195968e1bb5b, 0xc4168018d92196d9 };

    // 定义一个数组，存储解密后的数据，每个元素是一个ZZZ结构体
    ZZZ decrypted_data[8];

    // 循环遍历加密后的数据，每次取两个元素，分别是左半部分和右半部分
    for (int i = 0; i < 8; i += 2) {
        // 定义两个64位无符号整数，用来存储左半部分和右半部分的值
        uint64_t left, right;
        // 从加密后的数据中获取左半部分和右半部分的值
        left = encrypted_data[i];
        right = encrypted_data[i + 1];
        // 调用解密函数，对左半部分和右半部分进行解密
        decrypt(&left, &right, key);
        // 把解密后的左半部分和右半部分的值设置到解密后的数据的对应位置
        set_val(&decrypted_data[i], left);
        set_val(&decrypted_data[i + 1], right);
    }

    // 循环遍历解密后的数据，把每个元素转换成字节数组，并按照逆序排列，然后转换成ASCII编码的字符串，并输出到控制台
    for (int i = 0; i < 8; i++) {
        // 获取解密后的数据的第i个元素的字节数组
        uint8_t *bytes = get_bytes(&decrypted_data[i])->bytes;
        // 循环遍历字节数组，从后往前输出每个字节
        for (int j = 7; j >= 0; j--) {
            // 把字