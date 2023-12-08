#include <stdio.h>
#include <stdlib.h>
#include <string.h>
char *__cdecl wrong(char *a1)
{
  char *result; // eax
  int i; // [esp+Ch] [ebp-4h]
    char str[] = {0x66, 0x6b, 0x63, 0x64, 0x7f, 0x61, 0x67, 0x64, 0x3b, 0x56, 0x6b, 0x61, 0x7b, 0x26, 0x3b, 0x50, 0x63, 0x5f, 0x4d, 0x5a, 0x71, 0x0c, 0x37, 0x66};

  for ( i = 0; i <= 23; ++i )
  {
      for (int k = 32; k <= 126;++k)
      {
          a1[i] = k;
          if ((i & 1) != 0)
              a1[i] -= i;
          else
              a1[i] ^= i;
          if (a1[i] == str[i])
          {
              printf("%c", k);
              break;
          }
      }
  }
  return result;
}

int main(int argc, char const *argv[])
{
    char Str[]= "flag{abcdefghijklmnopqr}";
    if (  strlen(Str)!= 24 )
  {
    puts("Wrong!");
    exit(0);
  }
  wrong(Str);

  return 0;
}
