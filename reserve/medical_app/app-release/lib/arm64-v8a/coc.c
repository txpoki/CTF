#include <stdio.h>
#include <stdlib.h>
int main(int argc, char const *argv[])
{
    unsigned int input[36] = {0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11};
    unsigned int enc[36] = {0x3E,0x97,0xE5,0x68,0x67,0x73,0x0C,0xC2,0x1B,0xD4,0xAF,0x98,0xE2,0x9D,0x4B,0xFE,0x0B,0xB6,0xA5,0x01,0x46,0xD6,0x36,0x3D,0xAF,0x7B,0xCC,0xDB,0x00,0x4F,0x41,0xA0,0x1A,0xE7,0x2C,0x76};
    unsigned int key[4]={0x00000001,0x00000010,0x00000100,0x00001000};
    unsigned int inp[9] = {0};
    unsigned int en[9] = {0};
    unsigned int tes[9] = {0x259afdab,0x93fc7b8a,0xfaf9a73d,0x7419f4a7,0xc35d61d3,0xfad3042c,0x3ad6e324,0xe94c6a6b,0x6541a8ae};
    __int64 Dn = 0;
    //for (int i = 0; i < 36; i+=4)
    //{
    //    inp[i / 4] = input[i] | input[i + 1]<<8 | input[i + 2]<<16 | input[i + 3]<<24;
    //}
    //unsigned int Delta = 0x9F5776B6;
    //for (int  i = 0; i < 12; i++)
    //{
    //    printf("第%d次加密\n",i);
    //    printf("Delta=0x%x\n", Delta);
    //    Dn = (Delta >> 2) & 3;
    //    inp[0] += (((4 * inp[1]) ^ (inp[8] >> 5)) + ((inp[1] >> 3) ^ (16 * inp[8]))) ^ ((key[Dn << 2] ^ inp[8]) + (inp[1] ^ Delta)); // 0
    //    inp[1] += (((4 * inp[2]) ^ (inp[0] >> 5)) + ((inp[2] >> 3) ^ (16 * inp[0]))) ^ ((key[(Dn ^ 1) << 2] ^ inp[0]) + (inp[2] ^ Delta));
    //    inp[2] += (((4 * inp[3]) ^ (inp[1] >> 5)) + ((inp[3] >> 3) ^ (16 * inp[1]))) ^ ((key[(Dn ^ 2) << 2] ^ inp[1]) + (inp[3] ^ Delta));
    //    inp[3] += (((4 * inp[4]) ^ (inp[2] >> 5)) + ((inp[4] >> 3) ^ (16 * inp[2]))) ^ ((key[(Dn ^ 3) << 2] ^ inp[2]) + (inp[4] ^ Delta)); // 12
    //    inp[4] += (((4 * inp[5]) ^ (inp[3] >> 5)) + ((inp[5] >> 3) ^ (16 * inp[3]))) ^ ((key[Dn << 2] ^ inp[3]) + (inp[5] ^ Delta));       // 16
    //    inp[5] += (((4 * inp[6]) ^ (inp[4] >> 5)) + ((inp[6] >> 3) ^ (16 * inp[4]))) ^ ((key[(Dn ^ 1) << 2] ^ inp[4]) + (inp[6] ^ Delta)); // 20
    //    inp[6] += (((4 * inp[7]) ^ (inp[5] >> 5)) + ((inp[7] >> 3) ^ (16 * inp[5]))) ^ ((key[(Dn ^ 2) << 2] ^ inp[5]) + (inp[7] ^ Delta));
    //    inp[7] += (((4 * inp[8]) ^ (inp[6] >> 5)) + ((inp[8] >> 3) ^ (16 * inp[6]))) ^ ((key[(Dn ^ 3) << 2] ^ inp[6]) + (inp[8] ^ Delta));
    //    inp[8] += (((4 * inp[0]) ^ (inp[7] >> 5)) + ((inp[0] >> 3) ^ (16 * inp[7]))) ^ ((key[Dn << 2] ^ inp[7]) + (inp[0] ^ Delta));
    //    Delta -= 0x60A8894A;
    //    for (int i = 0; i < 9; i++)
    //    {
    //        printf("inp[%d]=0x%08x\n", i, inp[i]);
    //    }
    //    
    //    printf("——————————————————————\n");
    //}

    for (int  i = 0; i < 36; i+=4)
    {
        en[i / 4] = enc[i] | enc[i + 1] << 8 | enc[i + 2] << 16 | enc[i + 3] << 24;
    }
    unsigned int Delta = 0xd8c219d2;
    for (int  i = 0; i < 11; i++)
    {
        printf("第%d次解密\n",i+1);
        printf("Delta=0x%x\n", Delta);
        Dn = (Delta >> 2) & 3;
        printf("%d\n", Dn);
        en[8] -= (((4 * en[0]) ^ (en[7] >> 5)) + ((en[0] >> 3) ^ (16 * en[7]))) ^ ((key[Dn ] ^ en[7]) + (en[0] ^ Delta));
        en[7] -= (((4 * en[8]) ^ (en[6] >> 5)) + ((en[8] >> 3) ^ (16 * en[6]))) ^ ((key[(Dn ^ 3) ] ^ en[6]) + (en[8] ^ Delta));
        en[6] -= (((4 * en[7]) ^ (en[5] >> 5)) + ((en[7] >> 3) ^ (16 * en[5]))) ^ ((key[(Dn ^ 2) ] ^ en[5]) + (en[7] ^ Delta));
        en[5] -= (((4 * en[6]) ^ (en[4] >> 5)) + ((en[6] >> 3) ^ (16 * en[4]))) ^ ((key[(Dn ^ 1) ] ^ en[4]) + (en[6] ^ Delta)); // 20
        en[4] -= (((4 * en[5]) ^ (en[3] >> 5)) + ((en[5] >> 3) ^ (16 * en[3]))) ^ ((key[Dn ] ^ en[3]) + (en[5] ^ Delta));       // 16
        en[3] -= (((4 * en[4]) ^ (en[2] >> 5)) + ((en[4] >> 3) ^ (16 * en[2]))) ^ ((key[(Dn ^ 3) ] ^ en[2]) + (en[4] ^ Delta)); // 12
        en[2] -= (((4 * en[3]) ^ (en[1] >> 5)) + ((en[3] >> 3) ^ (16 * en[1]))) ^ ((key[(Dn ^ 2) ] ^ en[1]) + (en[3] ^ Delta));
        en[1] -= (((4 * en[2]) ^ (en[0] >> 5)) + ((en[2] >> 3) ^ (16 * en[0]))) ^ ((key[(Dn ^ 1) ] ^ en[0]) + (en[2] ^ Delta));
        en[0] -= (((4 * en[1]) ^ (en[8] >> 5)) + ((en[1] >> 3) ^ (16 * en[8]))) ^ ((key[Dn ] ^ en[8]) + (en[1] ^ Delta)); // 0
        Delta += 0x60A8894A;
        for (int i = 0; i < 9; i++)
        {
            printf("en[%d]=0x%08x\n", i, en[i]);
        }
        
        printf("——————————————————————\n");
    }
    
    
    return 0;
}
