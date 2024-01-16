#include <stdio.h>
int main(int argc, char const *argv[])
{
    unsigned int data[10] = {
    0xE112DBEA, 0xFDED929F, 0x06F2F6FC, 0xF2F6F8FD, 0xF3F687F8, 0xF1FCF6FC, 0x0EF689C0, 0xF6C7F8C1, 
    0x07C788CB, 0x08FE87C0
};
for (int i = 0; i <=9 ; i++)
{
    data[i] ^= 0x87654321;
    data[i] -= 0x12345678;
}
for (int i = 0; i <=9; i++)
{
    printf("%c%c%c%c", data[i]&0xFF, (data[i] >> 8)&0xFF, (data[i] >> 16)&0xFF, data[i]>>24 );
}


    return 0;
}
