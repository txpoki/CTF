#include <stdio.h>
#include <string.h>
#include <stdlib.h>

char *base64_encode(char *str);
void brute_force(char *str, int index, int max_depth, char *target);

int main() {
    char str[28] = {0};
    char *target = "PncXPjtYODNbDHZVCDNVS1pVP5MpU4IX85Iz";
    brute_force(str, 0, 27, target);
    return 0;
}

void brute_force(char *str, int index, int max_depth, char *target) {
    const char *charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+/=";
    if (index >= max_depth) {
        char *encoded = base64_encode(str);
        if (strcmp(encoded, target) == 0) {
            printf("Found match: %s\n", str);
        }
        free(encoded);
    } else {
        for (int i = 0; i < strlen(charset); ++i) {
            str[index] = charset[i];
            brute_force(str, index + 1, max_depth, target);
        }
    }
}

char *base64_encode(char *str) {
     int len; // 字符串长度
  int n; // 编码后的长度
  char *res; // 编码后的字符串
  int i; // 循环变量
  int j; // 循环变量
  int v2;
  char table[] = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+/"; // 字符表

  len = strlen(str); // 计算字符串长度
  if (len % 3 == 0) // 如果长度是3的倍数
    n = 4 * (len / 3); // 编码后的长度是4倍
  else // 如果长度不是3的倍数
    n = 4 * (len / 3 + 1); // 编码后的长度是4倍加4
  res = (char *)malloc(n + 1); // 分配内存空间
  memset(res, 0, n + 1); // 初始化为0
  j = 0; // 初始化循环变量
  for (i = 0; i < n - 2; i += 4) // 每次处理4个字符
  {
    res[i] = table[(str[j] >> 2) & 0x3F]; // 取第一个字节的前6位
    res[i + 1] = table[((4*str[j+1]) & 0x3C) | (str[j + 2] >> 6)]; // 取第一个字节的后2位和第二个字节的前4位
    res[i + 2] = table[((16*str[j]) & 0x30) | (str[j + 1] >> 4)]; // 取第二个字节的后4位和第三个字节的前2位
    v2 = i + 3;
    res[v2]=table[str[j + 2] & 0x3F];
    j += 3; // 更新循环变量
  }
  if (len % 3 == 1) // 如果长度余1
  {
    res[i - 2] = '='; // 填充两个等号
    res[i - 1] = '=';
  }
  else if (len % 3 == 2) // 如果长度余2
  {
    res[i - 1] = '='; // 填充一个等号
  }
  res[i] = '\0'; // 结束符
  return res; // 返回编码后的字符串
}
