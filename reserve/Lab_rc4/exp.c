#include <stdio.h>
#include <stdlib.h>
#include <stddef.h>
unsigned int* sub_401410(int s, int a2, int key) {
    unsigned int* result = (unsigned int*)malloc(256 * sizeof(unsigned int));
    int v4 = 0;

    for (int i = 0; i <= 255; ++i) {
        result[i] = i;
        result[i + a2 / 4] = result[i % 8 + key / 4];
    }

    for (int j = 0; j <= 255; ++j) {
        v4 = (unsigned char)(v4 + result[j + s / 4] + result[j + a2 / 4]);
        result[j + s / 4] ^= result[v4 + s / 4];
        result[v4 + s / 4] ^= result[j + s / 4];
        result[j + s / 4] ^= result[v4 + s / 4];
    }

    return result;
}
int sub_401563(int *a1, int *a2, int a3)
{
  int result; // eax
  int i; // [esp+4h] [ebp-10h]
  int v5; // [esp+8h] [ebp-Ch]
  int v6; // [esp+Ch] [ebp-8h]

  v6 = 0;
unsigned char lowByte = LOBYTE(v5);
lowByte = 0;
  for ( i = 0; ; ++i )
  {
    result = i;
    if ( i >= a3 )
      break;
    v6 = (v6 + 1) % 256;
    v5 = (*(4 * v6 + a1) + v5);
    *(4 * v6 + a1) ^= *(4 * v5 + a1);
    *(4 * v5 + a1) ^= *(4 * v6 + a1);
    *(4 * v6 + a1) ^= *(4 * v5 + a1);
    *(4 * i + a2) ^= *(4 * (*(4 * v6 + a1) + *(4 * v5 + a1))
                                         + a1) ^ (i + 60);
  }
  return result;
}
int main(int argc, char const *argv[])
{
    int input[32]={0x7,0x93,0x9b,0xb1,0xe8,0x33,0xac,0xa3,0x68,0xc5,0xab,0x40,0xaf,0x3b,0x3e,0xb5,0xc4,0xf9,0x66,0x64,0xd1,0xdf,0xe,0xeb,0x88,0xd7,0x6,0xa8,0x8a,0x24,0x11,0x88};
    char v4[8] = "Scr1w666";
    int *v5 = malloc(120);
    int *v6 = malloc(120);
    int *v9 = malloc(1024);
    void *v8 = malloc(1024);
    memset(v9,0,256);
    memset(v8,0,256);

    memset(v6, 0, 30);
    memset(v5, 0, 30);

    for (int i = 0; i <= 15; ++i)
    {
        *( i + v6) = *(2 * i + input);//偶数项
        *( i + v5) = *(2 * i + 1 + input);//奇数项
    }
sub_401410(v9, v8, v4);
sub_401563(v9, v6, 16);
sub_401563(v9, v5, 16);
printf("%s",v6);
printf("%s",v5);

return 0;
}

