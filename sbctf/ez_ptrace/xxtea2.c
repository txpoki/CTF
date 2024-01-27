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
    uint32_t encryptedData[] = {0x0913BC10, 0x7AD2DE6F, 0xEC01321E, 0x33C2A85D, 0x4476C2DE, 0x59714E3B, 0xF5B45769, 0x04B4E6EC};
    int dataSize = sizeof(encryptedData) / sizeof(encryptedData[0]);

    // Example key (you should replace this with your actual key)
    uint32_t key[] = {'t', 'q', 'l', '!'};

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

