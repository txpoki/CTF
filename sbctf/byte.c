#include <stdio.h>
#include <stdint.h>

int main() {
    uint32_t sou[24] = { 73, -65, 27, -19, -77, 28, 108, 82, 43, 60, -14, 58, 28, 44, -21, 77, 31, 114, 43, 98, 88, 17, 23, -9};
  uint32_t k[4] = {1732584193,-271733879,-1732584194,271733878};

    for (int i = 0; i < 4; ++i) {
        printf("0x%X,", k[i]);  // 打印一字节的十六进制数
    }

    return 0;
}
