#include <stdio.h>
#include <string.h>
#include <stdlib.h>
char *base64_encode(char *str);
int main(){
    char *str = "fla";
    str=base64_encode(str);
    printf("%s", str);
    return 0;
}
char *base64_encode(char *str)
{
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
    res[i + 2] = table[((str[j+1]<<2) & 0x3C) | (str[j + 2] >> 6)]; //取第二个字节的后四位作为中间四位，第三个字节的前两位被变成最后两位
    res[i + 1] = table[((str[j]<<4) & 0x30) | (str[j + 1] >> 4)]; // 取第一个字节的最后两位变成前两位，第二个字节的前四位变成最后四位
    v2 = i + 3;
    res[v2]=table[str[j + 2] & 0x3F];//取第三个字节的最后六位
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
