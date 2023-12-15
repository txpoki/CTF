#include <stdio.h>

int decrypt(unsigned int *a4,int *a5){
  int v7 = 12;
  unsigned int v9 = 0x6a99b4ac;
  unsigned int v10 = a4[6];
  int v6;
  do
  {
    if (v7!=12)
    {
        v9 += 0x61C88647;
    }
    v6 = (v9 >> 2) & 3;
    a4[7] -= ((a4[0] ^ v9) + (v10 ^ a5[(v6 ^ 7 & 3)])) ^ (((a4[0] << 2) ^ (v10 >> 5)) + ((a4[0] >> 3) ^ (v10 << 4)));
    for (int i = 6; i >=0 ; i--)
    {
        if (i==0)
        {
        v10 = a4[7];
        }
        else{
        v10 = a4[i - 1];
        }
        
        a4[i] -= ((a4[i + 1] ^ v9) + (v10 ^ a5[(v6 ^ i & 3)])) ^ (((a4[i + 1] << 2) ^ (v10 >> 5)) + ((a4[i + 1] >> 3) ^ (v10 << 4)));
    }
    v10 = a4[6];
    v7--;
  } while (v7>0);
  if (a4[0]==0x73737363)
  {
    return 1;
  }
  else{
    return 0;
  }
  
  
}
int main(int argc, char const *argv[])
{
  //sssctf{aaaaaaaaaaaaaaaaaaaaaaaa}
    unsigned int a4[8] = {0xb047aa9b, 0xe99dc532, 0x633d363f, 0x8f5c80c3, 0xee875187, 0xb1906477, 0xfd6d416b, 0x3a5e1ccd};
    unsigned int cp[8] = {0};
    char a3[16] = {'s', 's', '\x00', '\x00', 'c', 's', '\x00', '\x00', 'f', 't', '\x00', '\x00', 'a', '{', '\x00', '\x00'};
    int a5[4] = {0};
     for (int i = 0; i < 4; i++)
  {
    a5[i] = (int)a3[4*i] | (int)a3[4*i + 1]<<8;
  }
  
for (int i = 32; i < 127; i++)
{
  for (int k =0 ; k < 8; k++)
  {
    cp[k] = a4[k];
  }
  
  a5[3] = i | '{' << 8;
  if(decrypt(cp,a5)){
    printf("win\n");
    for (int j = 0; j < 8; j++)
    {
      printf("%x", cp[j]);
    }
    
    break;
  }

}




    return 0;
}
