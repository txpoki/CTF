#include <stdio.h>
#include <stdlib.h>
#include <string.h>

unsigned int* initializeArray(int size) {
    return (unsigned int*)malloc(size * sizeof(unsigned int));
}

void swapValues(unsigned int* array, int index1, int index2) {
    unsigned int temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}

void keySetup(unsigned int* s, int * a2, char * key) {
    int v4;
    for (int i = 0; i <= 255; ++i) {
       *(s + 4 * i) = i;
        *(4 * i + a2) = *(4 * (i % 8) + key);
    }
    for (int j = 0; j <=255; ++j)
    {
       v4 = (unsigned __int8)(v4 + *(4 * j + s) + *(4 * j + a2));
    *(4 * j + s) ^= *(4 * v4 + s);
    *(4 * v4 + s) ^= *(4 * j + s);
    *(4 * j + s) ^= *(4 * v4 + s);
    }
    
}

void encryption(unsigned int* a1, unsigned int* a2, int a3) {
    int v5 = 0;

    for (int i = 0; i < a3; ++i) {
        v5 = (v5 + 1) % 256;
        unsigned char lowByte = v5 & 0xFF;
        a1[v5] = (a1[v5] + lowByte + a2[v5]) & 0xFF;

        swapValues(a1, v5, a1[v5]);
        swapValues(a2, v5, a1[v5]);

        a2[i] ^= a1[(a1[v5] + a2[v5]) % 256] ^ (i + 60);
    }
}

int main() {
    int input[32] = {0x7, 0x93, 0x9b, 0xb1, 0xe8, 0x33, 0xac, 0xa3, 0x68, 0xc5, 0xab, 0x40, 0xaf, 0x3b, 0x3e, 0xb5, 0xc4, 0xf9, 0x66, 0x64, 0xd1, 0xdf, 0xe, 0xeb, 0x88, 0xd7, 0x6, 0xa8, 0x8a, 0x24, 0x11, 0x88};
    char v4[8] = "Scr1w666";
    
    unsigned int* v6 = initializeArray(256);
    unsigned int* v5 = initializeArray(256);
    unsigned int* v9 = initializeArray(256);
    unsigned int* v8 = initializeArray(256);

    memset(v9, 0, 256 * sizeof(unsigned int));
    memset(v8, 0, 256 * sizeof(unsigned int));

    for (int i = 0; i <= 15; ++i) {
        v6[i] = input[2 * i];      // Even terms
        v5[i] = input[2 * i + 1];  // Odd terms
    }

    keySetup(v9,v8, v4);
    encryption(v9, v6, 16);
    encryption(v9, v5, 16);

    for (int i = 0; i < 16; ++i) {
        printf("%c", (char)v6[i]);
    }
    
    for (int i = 0; i < 16; ++i) {
        printf("%c", (char)v5[i]);
    }

    free(v6);
    free(v5);
    free(v9);
    free(v8);

    return 0;
}
