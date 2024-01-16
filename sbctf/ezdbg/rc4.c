#include <stdio.h>
#include <string.h>

void swap(unsigned char *a, unsigned char *b) {
    unsigned char temp = *a;
    *a = *b;
    *b = temp;
}

void custom_rc4_init(unsigned char *key, unsigned char *a2, unsigned char *S) {
    int v4;
    for (int i = 0; i <= 255; ++i) {
        S[i] = i;
        a2[i] = key[i % 8];
    }
    for (int j = 0; j <= 255; ++j) {
        if (j==0)
        {
            v4 = 0x9E;
        }
        else{
        v4 = (v4+S[j] + a2[j]) & 0xFF;
            }
        swap(&S[j],&S[v4]);
    }
}

void custom_rc4_encrypt(unsigned char *input,unsigned char S[256]) {
    int v6 = 0, v5 = 0;
    for (int k = 0; k < 16; k++) {
    v6 = ( k +1) % 256;
    v5 = (*(v6 + S) + v5) & 0xFF;
  
    swap(&S[v6],&S[v5]);
    input[k]^= *((S[v6]+S[v5])+ S) ^ (k + 60);
    }
}

int main() {
    unsigned char key[8] = "Scr1w666";
    unsigned char plaintext[32] = "flag{aaaaaaaaaaaaaaaaaaaaaaaaaa}";
    unsigned char even[16]={0};
    unsigned char odd[16]={0};
    for(int i=0;i<16;i++){
        even[i]=plaintext[2*i];
        odd[i]=plaintext[2*i+1];
    }
  

    unsigned char S[256];
    unsigned char v8[256];
    custom_rc4_init(key,v8, S);

    unsigned char ciphertext[16];
    custom_rc4_encrypt(even, S);

    printf("even: ");
    for (int i = 0; i < 16; ++i) {
        printf("%02X ", even[i]);
    }
    printf("\n");
    custom_rc4_encrypt(odd, S);

    printf("odd: ");
    for (int i = 0; i < 16; ++i) {
        printf("%02X ", odd[i]);
    }
    printf("\n");
    return 0;
}

//flag{aaaaaaaaaaaaaaaaaaaaaaaaaa}