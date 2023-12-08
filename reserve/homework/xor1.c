#include <stdio.h>
#include <stdint.h>

__int64 __fastcall customXOR(char root, unsigned __int8 tmp)
{
  char v2; // dl
  char v4; // [rsp+1h] [rbp-1h]
  char v5; // [rsp+1h] [rbp-1h]
  unsigned __int8 v6; // [rsp+1h] [rbp-1h]

  v2 = 16
     * ((((8
         * ((((4
             * ((((2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 4 | (root & 1 ^ ((tmp & 2) != 0)) & 4 | root & 4) != 0) ^ ((tmp & 8) != 0))) & 8 | (2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 8 | (root & 1 ^ ((tmp & 2) != 0)) & 8 | root & 8) != 0) ^ ((tmp & 0x10) != 0))) & 0x10 | (4 * ((((2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 4 | (root & 1 ^ ((tmp & 2) != 0)) & 4 | root & 4) != 0) ^ ((tmp & 8) != 0))) & 0x10 | (2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 0x10 | (root & 1 ^ ((tmp & 2) != 0)) & 0x10 | root & 0x10) != 0) ^ ((tmp & 0x20) != 0));
  v4 = v2 | (8
           * ((((4
               * ((((2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 4 | (root & 1 ^ ((tmp & 2) != 0)) & 4 | root & 4) != 0) ^ ((tmp & 8) != 0))) & 8 | (2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 8 | (root & 1 ^ ((tmp & 2) != 0)) & 8 | root & 8) != 0) ^ ((tmp & 0x10) != 0))) & 0xEF | (4 * ((((2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 4 | (root & 1 ^ ((tmp & 2) != 0)) & 4 | root & 4) != 0) ^ ((tmp & 8) != 0))) & 0xE7 | (2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 0xE3 | root & 1 ^ ((tmp & 2) != 0) | root & 0xE0;
  v5 = (32
      * (((v2 & 0x20 | (8
                      * ((((4
                          * ((((2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 4 | (root & 1 ^ ((tmp & 2) != 0)) & 4 | root & 4) != 0) ^ ((tmp & 8) != 0))) & 8 | (2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 8 | (root & 1 ^ ((tmp & 2) != 0)) & 8 | root & 8) != 0) ^ ((tmp & 0x10) != 0))) & 0x20 | (4 * ((((2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 4 | (root & 1 ^ ((tmp & 2) != 0)) & 4 | root & 4) != 0) ^ ((tmp & 8) != 0))) & 0x20 | (2 * ((((root & 1 ^ ((tmp & 2) != 0)) & 2 | root & 2) != 0) ^ ((tmp & 4) != 0))) & 0x20 | (root & 1 ^ ((tmp & 2) != 0)) & 0x20 | root & 0x20) != 0) ^ ((tmp & 0x40) != 0))) | v4 & 0xDF;
  v6 = (((tmp >> 7) ^ ((v5 & 0x40) != 0)) << 6) | v5 & 0xBF;
  return (((v6 >> 7) ^ tmp & 1) << 7) | v6 & 0x7Fu;
}

int main() {
    char root = 'C';
    unsigned __int8 tmp = 125;
    __int64 result = customXOR(root, tmp);
    printf("The result is: %x\n", result);
    return 0;
}
