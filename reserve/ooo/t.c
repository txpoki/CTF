#include <stdio.h>
#include <string.h>

char byte_E5018[] = "ABCDFEGH1JKLRSTMNP0VWQUXY2a8cdefijklmnopghwxyqrstuvzOIZ34567b9+/";

void sub_E11A1(char* input, char* output) {
    for (int i = 0; i < strlen(input); i += 4) {
        int indices[4];
        indices[0] = strchr(byte_E5018, input[i]) - byte_E5018;
        indices[1] = strchr(byte_E5018, input[i + 1]) - byte_E5018;
        indices[2] = strchr(byte_E5018, input[i + 2]) - byte_E5018;
        indices[3] = strchr(byte_E5018, input[i + 3]) - byte_E5018;

        output[i / 4 * 3] = (((indices[0] & 0x30) << 2) | (indices[1] & 3) | ((indices[2] & 0xC) << 2) | ((indices[3] & 0x30) >> 2)) & 0xFF;
        output[i / 4 * 3 + 1] = (((indices[0] & 0xC) << 2) | ((indices[1] & 0x30) << 2) | ((indices[2] & 3) | ((indices[3] & 0xC)))) & 0xFF;
        output[i / 4 * 3 + 2] = (((indices[0] & 3) | ((indices[1] & 0xC) << 2) | ((indices[2] & 0x30) << 2) | ((indices[3] & 3) << 2))) & 0xFF;
    }
}

int main() {
    // 输入编码后的字符串
    char encoded[] = "2aYcdfL2fS1BTMMF1RSeMTTASS1OJ8RHTJdBYJ2STJfNMSMAYcKUJddp";
    int output_len = strlen(encoded) * 3 / 4 + 1;

    // 输出字符串
    char decoded[output_len];

    sub_E11A1(encoded, decoded);

    // 打印输出字符串
    printf("%s\n", decoded);

    return 0;
}
