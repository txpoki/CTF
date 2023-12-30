#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// 定义XXTEA的常量
#define DELTA 0x9e3779b9
#define MX (((z>>5^y<<2) + (y>>3^z<<4)) ^ ((sum^y) + (key[(p&3)^e] ^ z)))

// 定义XXTEA的加密函数，输入和输出都是原始二进制数据，key也是原始二进制数据，klen是key的长度（字节）
void btea_encrypt(unsigned char *v, int n, unsigned char *key, int klen) {
    unsigned int *k, *u;
    unsigned int z, y, sum, e, p, q;
    int i;
    // 检查输入的有效性
    if (n < 2 || v == NULL || key == NULL || klen < 16) return;
    // 将key扩展为4个32位整数
    k = (unsigned int *)malloc(4 * sizeof(unsigned int));
    for (i = 0; i < 4; i++) {
        k[i] = 0;
        memcpy(&k[i], key + i * 4, klen > i * 4 + 4 ? 4 : klen - i * 4);
    }
    // 将v转换为32位整数数组
    u = (unsigned int *)v;
    n = n / 4;
    // 开始加密
    z = u[n - 1];
    y = u[0];
    q = 6 + 52 / n;
    sum = 0;
    while (q-- > 0) {
        sum += DELTA;
        e = sum >> 2 & 3;
        for (p = 0; p < n - 1; p++) {
            y = u[p + 1];
            u[p] += MX;
            z = u[p];
        }
        y = u[0];
        u[n - 1] += MX;
        z = u[n - 1];
    }
    // 释放内存
    free(k);
}

// 定义XXTEA的解密函数，输入和输出都是原始二进制数据，key也是原始二进制数据，klen是key的长度（字节）
void btea_decrypt(unsigned char *v, int n, unsigned char *key, int klen) {
    unsigned int *k, *u;
    unsigned int z, y, sum, e, p, q;
    int i;
    // 检查输入的有效性
    if (n < 2 || v == NULL || key == NULL || klen < 16) return;
    // 将key扩展为4个32位整数
    k = (unsigned int *)malloc(4 * sizeof(unsigned int));
    for (i = 0; i < 4; i++) {
        k[i] = 0;
        memcpy(&k[i], key + i * 4, klen > i * 4 + 4 ? 4 : klen - i * 4);
    }
    // 将v转换为32位整数数组
    u = (unsigned int *)v;
    n = n / 4;
    // 开始解密
    z = u[n - 1];
    y = u[0];
    q = 6 + 52 / n;
    sum = q * DELTA;
    while (sum != 0) {
        e = sum >> 2 & 3;
        for (p = n - 1; p > 0; p--) {
            z = u[p - 1];
            u[p] -= MX;
            y = u[p];
        }
        z = u[n - 1];
        u[0] -= MX;
        y = u[0];
        sum -= DELTA;
    }
    // 释放内存
    free(k);
}

// 定义一个测试函数，用于演示加密和解密的过程
void test() {
    // 定义一个测试字符串
    char *s = "Hello, world!";
    // 定义一个测试密钥
    char *k = "1234567890abcdef";
    // 打印原始字符串
    printf("Original: %s\n", s);
    // 加密字符串
    btea_encrypt((unsigned char *)s, strlen(s), (unsigned char *)k, strlen(k));
    // 打印加密后的字符串
    printf("Encrypted: ");
    for (int i = 0; i < strlen(s); i++) {
        printf("%02x", (unsigned char)s[i]);
    }
    printf("\n");
    // 解密字符串
    btea_decrypt((unsigned char *)s, strlen(s), (unsigned char *)k, strlen(k));
    // 打印解密后的字符串
    printf("Decrypted: %s\n", s);
}

// 主函数，调用测试函数
int main() {
    test();
    return 0;
}
