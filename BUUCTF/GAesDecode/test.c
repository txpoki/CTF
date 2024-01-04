#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <stdint.h>

// Simple matrix class
typedef struct {
    uint8_t state[32];
} LightState;

void addRoundKey(LightState* state, const uint8_t* roundKey) {
    for (int i = 0; i < 16; ++i) {
        state->state[i] ^= roundKey[i];
    }
}

void substitute(LightState* state) {
    // Simplified substitution (you may need a proper S-box)
    for (int i = 0; i < 16; ++i) {
        state->state[i] ^= 0x0F;
    }
}

void shiftRows(LightState* state) {
    // Simplified shiftRows (you may need a proper implementation)
    uint8_t temp[4];
    for (int i = 1; i < 4; ++i) {
        for (int j = 0; j < 4; ++j) {
            temp[j] = state->state[i * 4 + j];
        }
        for (int j = 0; j < 4; ++j) {
            state->state[i * 4 + j] = temp[(j + i) % 4];
        }
    }
}

void mixColumns(LightState* state) {
    // Simplified mixColumns (you may need a proper implementation)
    for (int i = 0; i < 4; ++i) {
        uint8_t a = state->state[i];
        uint8_t b = state->state[i + 4];
        uint8_t c = state->state[i + 8];
        uint8_t d = state->state[i + 12];

        state->state[i] = a ^ b ^ c ^ d;
        state->state[i + 4] = a ^ b ^ c ^ d;
        state->state[i + 8] = a ^ b ^ c ^ d;
        state->state[i + 12] = a ^ b ^ c ^ d;
    }
}

void encrypt(char* plainText, char* key, char* result) {
    char *keyBytes =key;
    char *plainTextBytes = plainText;
    int length = ((strlen(plainText) + 15) / 16) * 16;
    char resultBytes[32] ={0} ;

    // Convert key and plaintext to bytes

    // Encrypt each block
    int x= strlen(plainTextBytes);
    for (int i = 0; i < strlen(plainTextBytes); i += 16) {
        LightState state;
        memcpy(state.state, &plainTextBytes[i], 16);

        for (int round = 0; round <= 10; ++round) {
            char roundKey[16];

            for (int j = 0; j < 16; ++j) {
                roundKey[j] = keyBytes[round * 16 + j];
            }

            if (round == 0) {
                addRoundKey(&state, roundKey);
            } else if (round < 10) {
                substitute(&state);
                shiftRows(&state);
                mixColumns(&state);
                addRoundKey(&state, roundKey);
            } else {
                substitute(&state);
                shiftRows(&state);
                addRoundKey(&state, roundKey);
            }
        }

for (int k = 0; k <16 ; k++)
{
   resultBytes[k + i] = state.state[k];
}

    }
  memcpy(result, resultBytes, 32);
    // Base64 encode the result
    // (You need to implement or include a Base64 encoding function)
    // Here, I'm assuming you have a function called base64_encode.
    // You can replace it with your actual Base64 encoding implementation.
    // base64_encode(resultBytes, result);
}

int main() {
    char* plainText = "11111111111111111111111111111111";
    char* key = "This is a AES-like encryption algorithm. However, we do some change. Therefore, you cannot directly use security class to decrypt the message. Our challenge is to find the plain text of this encrypt message with th fixed key. ";
    char final[] = {0x90,0xd9,0x37,0x43,0x3f,0xa5,0xfe,0x42,0xe9,0x1a,0xe2,0xb1,0x7f,0x98,0x86,0x13,0xd7,0x0e,0xa1,0x39,0xa6,0x9f,0xd0,0x1c,0xf9,0x47,0x45,0xe1,0xbd,0x82,0x1e,0xa5};
    char result[32]; // Adjust the size accordingly

    encrypt(plainText, key, result);

    printf("Plaintext: %s\n", plainText);
    for (int i = 0; i < 32; i++)
    {
        printf("0x%x,",result[i]&0xff);
    }
    

    return 0;
}
