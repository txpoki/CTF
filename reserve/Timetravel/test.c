#include <stdio.h>
unsigned __int8 main()
{
  int v0; // r9
  int v1; // r5
  int v2; // r1
  int v3; // r2
  int v4; // r11
  unsigned char *k_init; // r6
  unsigned char *result; // r0
  int i; // r4
  unsigned char *k_final; // r3
  unsigned char *v9; // r0
  int v10; // r9
  int v11; // r1
  int v12; // r2
  int v13; // r6
  int v14; // r5
  int v15; // [sp+0h] [bp-24h]
  int v16; // [sp+4h] [bp-20h]
  unsigned char aAbcdefghijklmn[63] = {0};
  unsigned char dword_1B5E8[256] = {0};
  unsigned char k[256] = {0};
  v1 = 0x84210843;
  v2 = 0xD401515A;
  v3 = 0xE6FED93D;
  v4 = 0;
  k_init = dword_1B5E8;
  result = k;
  for ( i = 0xDE8392DB; ; i = 0xE6FED93D )
  {
    while ( 1 )
    {
      while ( i > 0xDE8392DA )
      {
        if ( i == 0xDE8392DB )
        {
          v15 = v4;
          i = v2;
          if ( v4 < 62 )
            i = 0x19BCBB1B;
        }
        else if ( i == v3 )
        {
          v16 = v0;
          i = 0xA299E938;
          if ( v0 < 256 )
            i = 0x9F1C79CC;
        }
        else
        {
          dword_1B5E8[v15] = aAbcdefghijklmn[0x3D - v15];
          i = 0xDE8392DB;
          v4 = v15 + 1;
        }
      }
      if ( i != 0x9F1C79CC )
        break;
      k_final = result;
      v9 = k_init;
      v10 = v2;
      v11 = v3;
      v12 = v1;
      v13 = ((v1 * v16) >> 32) + v16;
      v14 = (v13 >> 5) + (v13 >> 0x1F);
      k_init = v9;
      result = k_final;
      k_final[v16] = k_init[v16 - 62 * v14];
      v1 = v12;
      v3 = v11;
      v2 = v10;
      v0 = v16 + 1;
      i = 0xE6FED93D;
    }
    if ( i == 0xA299E938 )
      break;
    v0 = 0;
  }
  return 0;
}