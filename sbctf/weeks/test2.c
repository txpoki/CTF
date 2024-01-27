#include <stdio.h>
int main(int argc, char const *argv[])
{
    char base64_table[] = "RSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/ABCDEFGHIJKLMNOPQ";
    char str[] = {0xe,0x3e,0x32,0x13,0x32,0x2a,0x23,0x5b,0xe,0x34,0x5b,0x24,0x1a,0x57,0x1d,0x2a,0x63,0xe,0x1d,0x5d,0x22,0x20,0x21,0xe3,0xfa,0x68,0xd6};
    char res[36] ;
     for(int i=0,j=0;i<36;j+=3,i+=4)  
    {  
        res[i]=base64_table[str[j]>>2]; //取出第一个字符的前6位并找出对应的结果字符
        printf("0x%x ",res[i]&0xff);
        res[i+1]=base64_table[(str[j]&0x3)<<4 | (str[j+1]>>4)]; //将第一个字符的后位与第二个字符的前4位进行组合并找到对应的结果字符  
        printf("0x%x ",res[i+1]&0xff);
        res[i+2]=base64_table[(str[j+1]&0xf)<<2 | (str[j+2]>>6)]; //将第二个字符的后4位与第三个字符的前2位组合并找出对应的结果字符  
        printf("0x%x ",res[i+2]&0xff);
        res[i+3]=base64_table[str[j+2]&0x3f]; //取出第三个字符的后6位并找出结果字符  
        printf("0x%x ",res[i+3]&0xff);
    }  

    
    return 0;
}
