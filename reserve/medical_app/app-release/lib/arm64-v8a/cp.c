#include <stdio.h>
#include <stdlib.h>
int main()
{

  char (*input)[36]; // x19
  __int64 v4; // x9
  char v5; // w12
  __int64 v6; // x9
  signed int v7; // w12
  int v8; // w13
  int v9; // w12
  int v10; // w14
  int v11; // w10
  __int64 v12; // x9
  signed int v13; // w12
  int v14; // w13
  int v15; // w10
  int v16; // w14
  int v17; // w12
  int v18; // w15
  unsigned int input_32; // w1
  unsigned int input_0; // w9
  unsigned int input_16; // w10
  unsigned int input_20; // w11
  unsigned int input_24; // w12
  unsigned int input_8; // w13
  unsigned int input_12; // w14
  int v26; // w16
  unsigned int Delta; // w17
  __int64 Delta_num; // x2
  unsigned int input_4; // w3
  __int64 Delta_num_2; // x0
  __int64 v31; // x6
  unsigned int v32; // w3
  __int64 v33; // x1
  __int64 v34; // x2
  int v35; // w5
  unsigned int v36; // w7
  int v37; // cf
  __int128 v39[16]; // [xsp+0h] [xbp-210h] BYREF
  __int128 v40[16]; // [xsp+100h] [xbp-110h] BYREF
  __int64 v41; // [xsp+208h] [xbp-8h]

  char input[36] ={0} ;
  if ( strlen(input) != 36 )
    return 0LL;
  v4 = 0LL;
  memset(v39, 0, sizeof(v39));
  memset(v40, 0, sizeof(v40));
  do
  {
    v5 = *(&d + (v4 & 0xF));
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
    (*input)[v12++] ^= *(v39 + (*(v39 + v11) + v16));
  }
  while ( v12 != 36 );
  input_32 = *&(*input)[32];
  input_0 = *input;
  input_16 = *&(*input)[16];
  input_20 = *&(*input)[20];
  input_24 = *&(*input)[24];
  input_8 = *&(*input)[8];
  input_12 = *&(*input)[12];
  v26 = -11;
  Delta = 0x9F5776B6;
  do
  {
    Delta_num = (Delta >> 2) & 3;
    input_4 = *&(*input)[4];
    Delta_num_2 = 4 * Delta_num;
    input_0 += (((4 * input_4) ^ (input_32 >> 5)) + ((input_4 >> 3) ^ (16 * input_32))) ^ ((*(&d + Delta_num) ^ input_32)
                                                                                         + (input_4 ^ Delta));// 0
    v31 = 4LL * (Delta_num ^ 1);
    *input = input_0;
    v32 = ((((4 * input_8) ^ (input_0 >> 5)) + ((input_8 >> 3) ^ (16 * input_0))) ^ ((*(&d + v31) ^ input_0)
                                                                                   + (input_8 ^ Delta)))
        + input_4;
    v33 = 4LL * (Delta_num ^ 2);
    *&(*input)[4] = v32;                        // 4
    input_8 += (((4 * input_12) ^ (v32 >> 5)) + ((input_12 >> 3) ^ (16 * v32))) ^ ((*(&d + v33) ^ v32)
                                                                                 + (input_12 ^ Delta));
    v34 = 4LL * (Delta_num ^ 3);
    *&(*input)[8] = input_8;                    // 8
    input_12 += (((4 * input_16) ^ (input_8 >> 5)) + ((input_16 >> 3) ^ (16 * input_8))) ^ ((*(&d + v34) ^ input_8)
                                                                                          + (input_16 ^ Delta));// 12
    *&(*input)[12] = input_12;
    input_16 += (((4 * input_20) ^ (input_12 >> 5)) + ((input_20 >> 3) ^ (16 * input_12))) ^ ((*(&d + Delta_num_2) ^ input_12)
                                                                                            + (input_20 ^ Delta));// 16
    *&(*input)[16] = input_16;
    v35 = *(&d + v31);
    LODWORD(v31) = *&(*input)[28];
    v36 = *&(*input)[32];
    v37 = __CFADD__(v26++, 1);
    input_20 += (((4 * input_24) ^ (input_16 >> 5)) + ((input_24 >> 3) ^ (16 * input_16))) ^ ((v35 ^ input_16)
                                                                                            + (input_24 ^ Delta));// 20
    *&(*input)[20] = input_20;
    input_24 += (((4 * v31) ^ (input_20 >> 5)) + ((v31 >> 3) ^ (16 * input_20))) ^ ((*(&d + v33) ^ input_20)
                                                                                  + (v31 ^ Delta));
    *&(*input)[24] = input_24;                  // 24
    LODWORD(v34) = ((((4 * v36) ^ (input_24 >> 5)) + ((v36 >> 3) ^ (16 * input_24))) ^ ((*(&d + v34) ^ input_24)
                                                                                      + (v36 ^ Delta)))
                 + v31;
    *&(*input)[28] = v34;                       // 28
    input_32 = ((((4 * input_0) ^ (v34 >> 5)) + ((input_0 >> 3) ^ (16 * v34))) ^ ((*(&d + Delta_num_2) ^ v34)
                                                                                + (input_0 ^ Delta)))
             + v36;
    Delta -= 0x60A8894A;
    *&(*input)[32] = input_32;                  // 32
  }
  while ( !v37 );
  return (*input ^ ss | *&(*input)[8] ^ qword_3448 | *&(*input)[16] ^ qword_3450 | *&(*input)[24] ^ qword_3458 | *&(*input)[32] ^ dword_3460) == 0;
}