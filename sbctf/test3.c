#include <stdint.h>
#include <stdio.h>
#include <string.h>

#define DELTA 0x9e3779b9
#define MX 32

void decryptTEA(uint32_t *v, uint32_t *k) {
    uint32_t v0 = v[0], v1 = v[1], sum = 0;
    uint32_t delta = DELTA;
    uint32_t k0 = k[0], k1 = k[1], k2 = k[2], k3 = k[3];

    for (int i = 0; i < MX; i++) {
        sum -= delta;
        v1 -= ((v0 << 4) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
        v0 -= ((v1 << 4) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
    }

    v[0] = v0;
    v[1] = v1;
}

void reverseBytes(uint32_t *v, int size) {
    for (int i = 0; i < size; i++) {
        v[i] = ((v[i] & 0xFF000000) >> 24) |
               ((v[i] & 0x00FF0000) >> 8) |
               ((v[i] & 0x0000FF00) << 8) |
               ((v[i] & 0x000000FF) << 24);
    }
}

int main() {
    uint32_t key[4] = {1732584193, -271733879, -1732584194, 271733878};

    // Replace this with the encrypted data obtained from the Java code
    uint32_t encryptedData[] = {};

    int dataSize = sizeof(encryptedData) / sizeof(encryptedData[0]);

    reverseBytes(key, 4);
    reverseBytes(encryptedData, dataSize);

    for (int i = 0; i < dataSize; i += 2) {
        decryptTEA(&encryptedData[i], key);
    }

    reverseBytes(encryptedData, dataSize);

    // Assuming the decrypted data represents ASCII characters
    printf("Decrypted String: %s\n", (char *)encryptedData);

    return 0;
}
