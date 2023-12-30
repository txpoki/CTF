#include <stdio.h>
int main(int argc, char const *argv[])
{
    unsigned int g = 0x9f1c79cc;
    int v13 = 0;
    int v14;
    unsigned char key[62] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    unsigned char k_init[256] = {0};
    unsigned char k_final[256] = {0};
    for (int i = 0; i < 62; i++)
    {
        k_final[i] = key[61 - i];
    }
    printf("%s",k_final);

    return 0;
}
