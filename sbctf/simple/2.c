#include <stdio.h>
#include <stdlib.h>
#include <string.h>
//SBCTF{aaaaaaaaaaaaaaaaa}
// 将字节数组转换为整数数组
static int *method1(unsigned char *r0, int len) {
    int *r1 = (int *)malloc(len / 4 * sizeof(int));
    int i = 0, j = 0;

    while (j < len) {
        r1[i] = (r0[j + 3] & 0xFF) | ((r0[j + 2] & 0xFF) << 8) | ((r0[j + 1] & 0xFF) << 16) | (r0[j] << 24);
        i++;
        j += 4;
    }

    return r1;
}

// 将整数数组转换为字节数组
static unsigned char *method2(int *r0, int len) {
    unsigned char *r1 = (unsigned char *)malloc(len * 4 * sizeof(unsigned char));
    int i = 0, j = 0;

    while (j < len * 4) {
        r1[j + 3] = (unsigned char)r0[i];
        r1[j + 2] = (unsigned char)(r0[i] >> 8);
        r1[j + 1] = (unsigned char)(r0[i] >> 16);
        r1[j] = (unsigned char)(r0[i] >> 24);
        i++;
        j += 4;
    }

    return r1;
}

// 使用XXTEA加密算法加密字节数组
static unsigned char *method3(unsigned char *r0, int len, int *r3) {
    int *r1 = method1(r0, len);
    int i = 0;

  
        int j = 0;
        int k = 0;
        int vv = 0;

        while (vv<33)
        {
             k-= 1640531527;
             vv++;
        }

        while (j < 33) {
            k += 1640531527;
            printf("————————————————————————%d\n",j);
            printf("k=0x%08x\n",k);
            printf("r1[0]=0x%08x\n",r1[0]);
            printf("r1[1]=0x%08x\n",r1[1]);
            int m = (r1[0] << 4) + r3[2];
            int n = (r1[0] + k) ^ m;
            int o = (r1[0] >> 5) + r3[3];
            int p = n ^ o;
            r1[1] -= p;
            int q = (r1[1] << 4) + r3[0];
            int r = (r1[1] + k) ^ q;
            int s = (r1[1] >> 5) + r3[1];
            int t = r ^ s;
            r1[0] -= t;
          
            j++;
 
        }

    

    unsigned char *result = method2(r1, len / 4);
    free(r1);
    return result;
}

// 将一个字节转换为一个正整数
static int method4(unsigned char b0) {
    return (b0 < 0) ? b0 + 256 : b0;
}

int main() {
    int r0[] = { 1732584193, -271733879, -1732584194, 271733878 };

    char vv[] = "SBCTF{aaaaaaaaaaaaaaaaa}";
    char r7[100]="SBCTF{aaaaaaaaaaaaaaaaa}";
    int len = strlen(r7);
    unsigned char *r16= (unsigned char *)r7;
                        // SBCTF{aaaaaaaaaaaaaaaaa}
    unsigned char r8[] = { 31, 114, 43, 98, 88, 17, 23, -9 };
    len = 8;
   
            r16[0] = 'S';
            r16[1] = 'B';
            r16[2] = 'C';
            r16[3] = 'T';
            r16[4] = 'F';
            r16[5] = '{';

            r16[6] = 'h';
            r16[7] = 'a';
            unsigned char *encrypted = method3(r8, len, r0);
        
        
//        int equal = 1;
//        for (int i = 0; i < 24; i++)
//        {
//            if (encrypted[i] != r8[i])
//            {
//                equal = 0;
//                break;
//            }
//    }
//        
//
//    if (equal) {
//        printf("right flag!\n");
//    } else {
//        printf("wrong flag!\n");
//    }
//
//    free(encrypted);
    return 0;
}

