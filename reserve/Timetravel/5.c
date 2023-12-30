#include <string.h>

unsigned char* decryptFunction() {
int v0; // r9
  int v4; // r11
int v10; // r9
  int v11; // r1
  int v12; // r2
  int v13; // r6
  int v14; // r5
  int v15; // [sp+0h] [bp-24h]
  int v16; // [sp+4h] [bp-20h]
	unsigned char key2[] = "9876543210zyxwvutsrqponmlkjihgfedcbaZYXWVUTSRQPONMLKJIHGFEDCBA";
  int v1 = 0x84210843;
  int v2 = -738111142;
  int v3 = -419505859;
  unsigned int* key = {0};
  unsigned char* result ={0} ;
  int i = -561802533;
  unsigned char* k;

  while (i != -1566971592) {
    if (i == 0x9F1C79CC) {
      k = result;
      unsigned int* v9 = key;
      int v10 = v2;
      int v11 = v3;
      int v12 = v1;
      int v13 = ((v1 * v16) >> 32) + v16;
      int v14 = (v13 >> 5) + (v13 >> 31);
      
      key = v9;
      result = k;
      k[v16] = key[v16 - 62 * v14];
      v1 = v12;
      v3 = v11;
      v2 = v10;
      v0 = v16 + 1;
      i = -419505859;
    } else {
      v15 = v4;
      i = v2;
      if (v4 < 62)
        i = 431799067;
      else if (i == v3) {
        v16 = v0;
        i = -1566971592;
        if (v0 < 256)
          i = -1625523764;
      } else {
        key[v15] =key2[61-v15] ;
        i = -561802533;
        v4 = v15 + 1;
      }
    }
  }

  return result;
}
int main(int argc, char const *argv[])
{
    decryptFunction();
    return 0;
}
