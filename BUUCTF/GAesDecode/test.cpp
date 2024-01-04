#include <iostream>
#include <vector>
#include <string>
#include <iomanip>

// Simple matrix class
class LightState {
public:
    LightState(const std::vector<uint8_t>& data) {
        state = data;
    }

    void addRoundKey(const std::vector<uint8_t>& roundKey) {
        for (size_t i = 0; i < 16; ++i) {
            state[i] ^= roundKey[i];
        }
    }

    void substitute() {
        // Simplified substitution (you may need a proper S-box)
        for (size_t i = 0; i < 16; ++i) {
            state[i] = substituteByte(state[i]);
        }
    }

    void shiftRows() {
        // Simplified shiftRows (you may need a proper implementation)
        std::rotate(state.begin() + 4, state.begin() + 8, state.begin() + 12);
    }

    void mixColumns() {
        // Simplified mixColumns (you may need a proper implementation)
        for (size_t i = 0; i < 4; ++i) {
            uint8_t a = state[i];
            uint8_t b = state[i + 4];
            uint8_t c = state[i + 8];
            uint8_t d = state[i + 12];

            state[i] = multiply(a, 2) ^ multiply(b, 3) ^ c ^ d;
            state[i + 4] = a ^ multiply(b, 2) ^ multiply(c, 3) ^ d;
            state[i + 8] = a ^ b ^ multiply(c, 2) ^ multiply(d, 3);
            state[i + 12] = multiply(a, 3) ^ b ^ c ^ multiply(d, 2);
        }
    }

    uint8_t value(size_t row, size_t col) const {
        return state[col * 4 + row];
    }

private:
    std::vector<uint8_t> state;

    static uint8_t substituteByte(uint8_t byte) {
        // Simplified substitution (you may need a proper S-box)
        return byte ^ 0x0F;
    }

    static uint8_t multiply(uint8_t a, uint8_t b) {
        // Simplified multiplication (you may need a proper implementation)
        return (b & 1) ? a : 0;
    }
};

std::string encrypt(const std::string& plainText, const std::string& key) {
    std::vector<uint8_t> keyBytes(key.begin(), key.end());
    std::vector<uint8_t> plainTextBytes(plainText.begin(), plainText.end());

    size_t length = ((plainTextBytes.size() + 15) / 16) * 16;
    std::vector<uint8_t> resultBytes(length);

    for (size_t i = 0; i < plainTextBytes.size(); i += 16) {
        std::vector<uint8_t> inputBytes(16);

        for (size_t j = 0; j < 16 && i + j < plainTextBytes.size(); ++j) {
            inputBytes[j] = plainTextBytes[i + j];
        }

        LightState state(inputBytes);

        for (int round = 0; round <= 10; ++round) {
            std::vector<uint8_t> roundKey(16);

            for (size_t j = 0; j < 16; ++j) {
                roundKey[j] = keyBytes[round * 16 + j];
            }

            if (round == 0) {
                state.addRoundKey(roundKey);
            } else if (round < 10) {
                state.substitute();
                state.shiftRows();
                state.mixColumns();
                state.addRoundKey(roundKey);
            } else {
                state.substitute();
                state.shiftRows();
                state.addRoundKey(roundKey);
            }
        }

        for (size_t row = 0; row < 4; ++row) {
            for (size_t col = 0; col < 4; ++col) {
                resultBytes[row * 4 + i + col] = state.value(row, col);
            }
        }
    }

    return base64_encode(resultBytes.data(), resultBytes.size());
}

int main() {
    std::string plainText = "Hello, World!";
    std::string key = "This is a AES-like encryption algorithm. However, we do some change. Therefore, you cannot directly use security class to decrypt the message. Our challenge is to find the plain text of this encrypt message with th fixed key.";

    std::string ciphertext = encrypt(plainText, key);

    std::cout << "Plaintext: " << plainText << std::endl;
    std::cout << "Ciphertext: " << ciphertext << std::endl;

    return 0;
}
