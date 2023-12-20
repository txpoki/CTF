#include <stdio.h>
#include <stdlib.h>
int main(int argc, char const *argv[])
{
char v5; 
  long long int v4;
  long long int v6; // x9
  signed int v7; // w12
  int v8; // w13
  int v9; // w12
  int v10; // w14
  int v11; // w10
  long long int v12; // x9
  int v15; // w10
  int v16; // w14
  int v17; // w12
  int v18; // w15
  signed int v13; // w12
  int v14; // w13
  unsigned int test;
  char v39[256] = {0}; // [xsp+0h] [xbp-210h] BYREF
  char v40[256]={0}; // [xsp+100h] [xbp-110h] BYREF
    int key[16] = {1,0,0,0,16,0,0,0,0,1,0,0,0,16,0,0};
    unsigned int enc[9] = {0xd4b00456,0x304d639c,0x05c0ce96,0x823bbe93,0xb2164b52,0x4db7338a,0x50997b6d,0x120cb1c2,0x930a84e1};
    char input[36] = {0};
    for (int i = 0; i < 36; i+=4)
    {
        input[i] = enc[i / 4] & 0xFF;
        input[i+1] = enc[i / 4]>>8 & 0xFF;
        input[i+2] = enc[i / 4]>>16 & 0xFF;
        input[i+3] = enc[i / 4]>>24 & 0xFF;
    }
    
    v4 = 0;
    do
    {
        v5 = key[(v4 & 0xF)];
        *(v39 + v4) = v4;
        *(v40 + v4++) = v5;
    }
  while ( v4 != 256 );
  v6 = 0LL;
  v7 = 0;
  do
  {
    v8 = *(v39 + v6);
    v9 = v7 + v8 + *(v40 + v6);
    v10 = v9 + 255;
    if ( v9 >= 0 )
      v10 = v9;
    v7 = v9 - (v10 & 0xFFFFFF00);
    *(v39 + v6++) = *(v39 + v7);
    *(v39 + v7) = v8;
  }
  while ( v6 != 256 );
  v11 = 0;
  v12 = 0LL;
  v13 = 0;
  do
  {
    v14 = v11 + 1;
    if ( v11 + 1 >= 0 )
      v15 = v11 + 1;
    else
      v15 = v11 + 256;
    v11 = v14 - (v15 & 0xFFFFFF00);
    v16 = *(v39 + v11);
    v17 = v13 + v16;
    v18 = v17 + 255;
    if ( v17 >= 0 )
      v18 = v17;
    v13 = v17 - (v18 & 0xFFFFFF00);
    *(v39 + v11) = *(v39 + v13);
    *(v39 + v13) = v16;
    test = *(v39 + (*(v39 + v11) + v16)%256);
    printf("%x\n", test);
    input[v12++] ^= test;
  }while ( v12 != 36 );

    return 0;
}
