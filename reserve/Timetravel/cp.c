#include<stdio.h>

char str[40] = {0};
unsigned char byte_17180[40] = {
    0xA8, 0xCE, 0xCE, 0xD7, 0xB1, 0x5A, 0x20, 0x4B, 
    0xAB, 0xA2, 0x23, 0xFA, 0xFC, 0xF0, 0xDF, 0xA5, 
    0xB4, 0x77, 0xE6, 0x41, 0xC4, 0x65, 0x84, 0x91, 
    0x8B, 0x0A, 0xE6, 0xAE, 0xBB, 0xB5, 0x37, 0xFD, 
    0xC0, 0xCB, 0x72, 0x78, 0x13, 0x91, 0xD3, 0x5E
};
/*
RC4初始化函数
*/
void rc4_init(unsigned char* s, unsigned char* key, unsigned long Len_k)
{
 unsigned int v12; // r2
 long long int v13; // r6
 long long int v14; // r5
 long long int v15; // [sp+0h] [bp-24h]
 long long int v16; // [sp+4h] [bp-20h]
 unsigned int v1 =  0x84210843;
	int i = 0, j = 0;
	char k[256] = { 0 };
	unsigned char tmp = 0;
	for (i = 0; i < 256; i++) {
		s[i] = i;
	}
    for ( v16 = 0; v16 < 256; v16++)
    {
        v13 = ((v1 * v16) >> 32) + v16;
        v14 = (v13 >> 5) + (v13 >> 31);
        k[v16] = key[v16 - 62 * v14];
    }
    
	for (i = 0; i < 256; i++) {
		j = (j + s[i] + k[i]) % 256;
		tmp = s[i];
		s[i] = s[j];
		s[j] = tmp;
	}
}

/*
RC4加解密函数
unsigned char* Data     加解密的数据
unsigned long Len_D     加解密数据的长度
unsigned char* key      密钥
unsigned long Len_k     密钥长度
*/
void rc4_crypt(unsigned char* Data, unsigned long Len_D, unsigned char* key, unsigned long Len_k) //加解密
{
	unsigned char s[256];
	rc4_init(s, key, Len_k);
	int i = 0, j = 0, t = 0;
	unsigned long k = 0;
	unsigned char tmp;
	for (k = 0; k < 40; k++) {
		i = (i + 1) % 256;
		j = (j + s[i]) % 256;
		tmp = s[i];
		s[i] = s[j];
		s[j] = tmp;
		t = (s[i] + s[j]) % 256;
		str[k] = s[t];
        str[k] = s[s[i]+s[j]-(( s[i] + s[j] + (((s[i]+s[j]) >>31 ) >>24 )) & 0x3FFFFF00)];
    }
}
void main()
{
	//字符串密钥
	unsigned char key[] = "9876543210zyxwvutsrqponmlkjihgfedcbaZYXWVUTSRQPONMLKJIHGFEDCBA";
	unsigned long key_len = sizeof(key) - 1;
	//数组密钥
	//unsigned char key[] = {};
	//unsigned long key_len = sizeof(key);

	//加解密数据
    int k=0;
    unsigned char data[7] = "xxxxxxy";
    //加解密
	rc4_crypt(data, sizeof(data), key, key_len);

    for (int i = 0; i < 40; i++)
    {
        for (k =32 ; k < 127; k++)
        {
            if (byte_17180[i]==(str[i] ^ k ^ i))
            {
                printf("%c", k);
                break;
            }
            
        }
        if (k==127)
        {
            printf("&");
        }
        
        
    }
    
	
}


