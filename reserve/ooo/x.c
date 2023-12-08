#include <stdio.h>
#include <string.h>
    char byte_E5018[] = "ABCDFEGH1JKLRSTMNP0VWQUXY2a8cdefijklmnopghwxyqrstuvzOIZ34567b9+/";

void sub_E11A0(char* input, int a2, char* a3) {
    int index;
    char encodedChar;

    // 具体的汇编指令转换为C语言伪代码
    index = ((4 * (input[2+a2] & 3)) | (input[1+a2] & 0x30) | (input[0+a2] & 0xC0)) >> 2;
                  //3  1100                 2   11 0000                     1 1100 0000
    encodedChar = byte_E5018[index];
    a3[(a2 / 3) * 4 + 0] = encodedChar;

    index = ((4 * (input[0+a2] & 3)) | (input[2+a2] & 0x30) | (input[1+a2] & 0xC0)) >> 2;
                   //1 1100                  3 11 0000                       2 1100 0000
    encodedChar = byte_E5018[index];
    a3[(a2 / 3) * 4 + 1] = encodedChar;

    index = ((4 * (input[1+a2] & 3)) | (input[0+a2] & 0x30) | (input[2+a2] & 0xC0)) >> 2;
                     //2 1100                  1  11 0000             3 1100 0000
    encodedChar = byte_E5018[index];
    a3[(a2 / 3) * 4 + 2] = encodedChar;

    index = ((input[2+a2] & 0xC) | ((input[1+a2] << 2) & 0x30) | ((input[0+a2] << 4) & 0xC0)) >> 2;
               //3  1100 0000               2   11 0000             1 1100 0000
                                             //    ``                      ``
    encodedChar = byte_E5018[index];
    a3[(a2 / 3) * 4 + 3] = encodedChar;
}


int main() {
    // 输入字符串
    char input[] = "flag{adhaljhshdasldhjasldahlsjdahdalha2d2}";
    int input_len = sizeof(input) / sizeof(char);

    // 输出字符串
    char output[input_len * 4 / 3 + 1];  // Base64编码后的长度大约是原始长度的4/3

    for (int i = 0; i < strlen(input); i+=3)
    {
        sub_E11A0(input,i,output);
    }
    

    // 调用函数

    // 打印输出字符串
    printf("%s\n", output);

    return 0;
}


