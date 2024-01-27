#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define DELTA 0x9e3779b9
#define MX (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (key[p & 3 ^ e] ^ z)

void xxtea_decrypt(uint32_t* v, int n, uint32_t const key[4]) {
    uint32_t y, z, sum;
    unsigned p, rounds, e;

   
    rounds = 6 + 52 / n;

    sum = rounds * DELTA;
    y = v[0];

    do {
        e = (sum >> 2) & 3;

        for (p = n - 1; p > 0; p--) {
            z = v[p - 1];
            y = v[p] -= MX;
        }

        z = v[n - 1];
        y = v[0] -= MX;

        sum -= DELTA;

    } while (--rounds);
}

int main() {
    // Example encrypted data (you should replace this with your actual encrypted data)
    uint32_t encryptedData[] = {0x3770E52D,0xAC07F92,0xECC8FFF3,0xA0E26317,0x1E0E43DC,0x8034A680,0xAA0DB403,0xFA341902,0x46DF4060,0xF82E22B4,0xE1D25B0A,0x5C419F7};
    int dataSize = sizeof(encryptedData) / sizeof(encryptedData[0]);

    // Example key (you should replace this with your actual key)
    uint32_t key[] = {0x11, 0x22, 0x33, 0x44};

    // Decrypt the data
    xxtea_decrypt(encryptedData, dataSize, key);

    // Print the decrypted data
    for (int i = 0; i < dataSize; i++) {
        for (int j = 0; j < sizeof(uint32_t) / sizeof(uint8_t); j++)
        {
            printf("%c", (encryptedData[i] >> (j * 8)) & 0xFF);

        }
    }

    return 0;
}
