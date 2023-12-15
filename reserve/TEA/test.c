#include <stdio.h>
int decrypt(unsigned int *a4,int *a5){
  int v7 = 12;
  unsigned int v9 = 0x6a99baac;
  unsigned int v10 = a4[6];
  int v6;
  do
  {
    if (v7!=12)
    {
        v9 += 0x61C88647;
    }
    v6 = (v9 >> 2) & 3;
    a4[7] -= ((a4[0] ^ v9) + (v10 ^ a5[(v6 ^ 6 & 3)])) ^ (((a4[0] << 2) ^ (v10 >> 5)) + ((a4[0] >> 3) ^ (v10 << 4)));
    for (int i = 6; i < 7; i--)
    {
        v10 = a4[i - 1];
        a4[i] -= ((a4[i + 1] ^ v9) + (v10 ^ a5[(v6 ^ i & 3)])) ^ (((a4[i + 1] << 2) ^ (v10 >> 5)) + ((a4[i + 1] >> 3) ^ (v10 << 4)));
    }
    v10 = a4[6];
    v7--;
  } while (v7>0);
  
}
int main(int argc, char const *argv[])

{
 unsigned int *v3; // eax
  unsigned int *v4; // eax
  unsigned int result; // eax
  int v6; // [esp+Ch] [ebp-1Ch]
  int v7; // [esp+10h] [ebp-18h]
  unsigned int i; // [esp+14h] [ebp-14h]
  unsigned int v9; // [esp+18h] [ebp-10h]
  unsigned int v10; // [esp+1Ch] [ebp-Ch]
  char a3[16] = {'s','s','\x00','\x00','c','s','\x00','\x00','f','t','\x00','\x00','a','{','\x00','\x00'};
  char a1[32] = "csssa{ftaaaaaaaaaaaaaaaaaaaa}aaa";
  unsigned int a4[8] = {0};
  int a5[4] = {0};

  for (int i = 0; i < 8; i++)
  {
      a4[i] = (unsigned int)a1[4*i] | (unsigned int)a1[4*i + 1]<<8 | (unsigned int)a1[4*i + 2]<<16 | (unsigned int)a1[4*i +3]<<24;
  }
  for (int i = 0; i < 4; i++)
  {
    a5[i] = (int)a3[4*i] | (int)a3[4*i + 1]<<8;
  }
  
  

  v7 = 12;
  v9 = 0;
  v10 = a4[7];
  do
  {
      v9 -= 0x61C88647;
      v6 = (v9 >> 2) & 3;
      
      printf("第%d次加密\n",13-v7);
      printf("v9=%x\n",v9);
      printf("v6=%d\n",v6);
      for ( i = 0; i <7 ; ++i )
      {
        a4[i] += ((a4[i + 1] ^ v9) + (v10 ^ a5[(v6^i & 3)])) ^ (((a4[i + 1] << 2) ^ (v10 >> 5))+ ((a4[i + 1] >> 3) ^ (v10 << 4)));
        v10 = a4[i];
        printf("a4[%d]=0x%08x\n",i, a4[i]);
      }
      a4[7] += ((a4[0] ^ v9) + (v10 ^ a5[(v6^i & 3)])) ^ (((a4[0] << 2) ^ (v10 >> 5)) + ((a4[0] >> 3) ^ (v10 << 4)));
        printf("a4[7]=0x%08x\n", a4[7]);
      v10 =a4[7];
      --v7;
      printf("——————————————————————————————————\n");
    }
    while ( v7 );





//    int key1[4] = {0x666c,0x6167,0x0,0x0};
    //unsigned int enc1[8] = {0};
    //int enc[32] = {0x9b, 0xaa, 0x47, 0xb0, 0x32, 0xc5, 0x9d, 0xe9, 0x3f, 0x36, 0x3d, 0x63, 0xc3, 0x80, 0x5c, 0x8f, 0x87, 0x51, 0x87, 0xee, 0x77, 0x64, 0x90, 0xb1, 0x6b, 0x41, 0x6d, 0xfd, 0xcd, 0x1c, 0x5e, 0x3a};
    //for (int i = 0; i < 8; i++)
    //{
        //enc1[i] = (unsigned int)enc[4 * i] | (unsigned int)enc[4 * i + 1] << 8 | (unsigned int)enc[4 * i + 2] << 16 | (unsigned int)enc[4 * i + 3] << 24;
  //}
  //unsigned int x10;
  //for (int c1 = 32; c1 < 126; c1++)
  //{
      //for (int c2 = 32; c2 < 126; c2++)
      //{
          //for (int c3 = 32; c3 < 126; c3++)
          //{

              //key1[3] = 0x7b << 8 | c1;
              //key1[4] = c2 | c3 << 8;
              //for (int i = 0; i < 12; i++)
              //{
                  //x10 = enc[7];
              //}
          //}
      //}
    

//}

    
    return 0;

}
