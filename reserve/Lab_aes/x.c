#include <stdio.h>
int main(int argc, char const *argv[])
{
   int final[16]={0xf8,0x0d,0x54,0x0a,0x0b,0x08,0x78,0xa9,0xfa,0x83,0xa5,0x7b,0x86,0x69,0xb2,0xaf};
   for (int i = 0; i < 16; i++)
   {
       printf("%c",final[i]);
   }
   
   return 0;
}
