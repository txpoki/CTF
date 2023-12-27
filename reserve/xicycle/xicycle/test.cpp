#include <iostream>
#include <queue>
#include <stack>
#include<math.h>
using namespace std;
unsigned char target[] =  { 0xe6,0xa9,0xf,0xab,0x4c,0xf,0x95,0xa1,0xb8,0xc5,0xc4,0x65,0xb0,0xf1,0x75,0x75,0xc6,0xb4,0x3c,0x45,0x35,0xfc,0x7b,0xdc,0xd3,0x98,0x62,0x81,0xc1,0x10,0x53,0x84 };
unsigned int s(unsigned int i2, unsigned int i3) {

    return (i2 + i3) & 65535;
}
unsigned int t(unsigned int i2, unsigned int i3) {
    unsigned int j2 = i2 * i3;
    return (j2 % 65537) & 65535;
}
unsigned int bytes[32] = { 0xe6,0xa9,0x0f,0xab,0x4c,0x0f,0x95,0xa1,
0xb8,0xc5,0xc4,0x65,0xb0,0xf1,0x75,0x75 };
unsigned int dfs(unsigned int x,string path) {
    //cout << path << endl;
    string key = "8c123456790abdef";
    if (x < 8) {
        for (unsigned int a = 0; a <key.size(); a++) {

            string temp = path + key[a];
            if (dfs(x + 1,temp) == 1)
                return 1;
            if (x == 0)
                cout << "------" << key[a] << "------" << endl;
        }
    }
    else {
            string temp = "88eec6934ac34f76" + path + "5956f6e5";
            //cout << temp<<endl;
            unsigned char bytes[32]={0};
            for (unsigned int a = 0; a < 32; a++) {
                bytes[a] = temp[a];
            }
            unsigned int iArr2[] = {12643, 25650, 12644, 13156, 13619, 25136, 13414, 14691, 25698, 51302, 51306, 26308, 24680, 52338, 50786, 50888, 52624, 54477, 35008, 53656, 58764, 50573, 37064, 50576, 39697, 33187, 12747, 6539, 6945, 37259, 8603, 8617, 18019, 38451, 5686, 17187, 5699, 13891, 21302, 8963, 26156, 27782, 17964, 34412, 34470, 27718, 1676, 50988, 3212, 22796, 55565, 19672, 16582, 28874, 19287, 56017};
            unsigned int i3 = 0;
            unsigned int i4 = 0;
            unsigned int i5 = 0;
            while (i3 < 32) {
                
                unsigned int i6 = i3 + 0;
                unsigned int i7 = i3 + 1;
                unsigned int i8 = ((bytes[i6] & 255) << 8) | (bytes[i7] & 255);
                unsigned int i9 = i3 + 2;
                unsigned int i10 = i3 + 3;
                unsigned int i11 = ((bytes[i9] & 255) << 8) | (bytes[i10] & 255);
                unsigned int i12 = i3 + 4;
                unsigned int i13 = i3 + 5;
                unsigned int i14 = (bytes[i13] & 255) | ((bytes[i12] & 255) << 8);
                unsigned int i15 = i3 + 6;
                unsigned int i16 = i3 + 7;
                unsigned int i17 = ((bytes[i15] & 255) << 8) | (bytes[i16] & 255);
                unsigned int i18 = i4;
                unsigned int i19 = 0;
                unsigned int i20 = 0;
                for (unsigned int i21 = 8; i19 < i21; i21 = 8) { // range(8)
                    unsigned int i22 = i20 + 1;
                    unsigned int i23 = i5;
                    unsigned int t2 = t(i8, iArr2[i20]);
                    unsigned int i24 = i22 + 1;
                    unsigned int s2 = s(i11, iArr2[i22]);
                    unsigned int i25 = i24 + 1;
                    unsigned int s3 = s(i14, iArr2[i24]);
                    unsigned int i26 = i25 + 1;
                    unsigned int t3 = t(i17, iArr2[i25]);
                    unsigned int i27 = i26 + 1;
                    unsigned int t4 = t(t2 ^ s3, iArr2[i26]);
                    unsigned int i28 = i15;
                    unsigned int t5 = t(s(s2 ^ t3, t4), iArr2[i27]);
                    unsigned int s4 = s(t4, t5);
                    i11 = s3 ^ t5;
                    i14 = s2 ^ s4;
                    i17 = t3 ^ s4;
                    i19++;
                    i8 = t2 ^ t5;
                    i5 = i23;
                    i20 = i27 + 1;
                    i15 = i28;
                }
                unsigned int i29 = i15;
                unsigned int i30 = i5;
                unsigned int i31 = i20 + 1;
                unsigned int t6 = t(i8, iArr2[i20]);
                unsigned int i32 = i31 + 1;
                unsigned int s5 = s(i14, iArr2[i31]);
                unsigned int i33 = i32 + 1;
                unsigned int s6 = s(i11, iArr2[i32]);
                unsigned int t7 = t(i17, iArr2[i33]);
                if (i3 >= 20) {
                    
                    unsigned int length = 32 / 4;
                    unsigned int iArr3[8];
                    unsigned int i34 = 0;
                    unsigned int i35 = 0;
                    while (i34 < length) {
                        iArr3[i34] = ((bytes[i35 + 2] & 255) << 8) | (bytes[i35 + 3] & 255) | ((bytes[i35 + 1] & 255) << 16) | ((bytes[i35 + 0] & 255) << 24);
                        i35 += 4;
                        i34++;
                    }
                    unsigned int i36 = (i3 / 4) - 2;
                    unsigned int i37 = i36 + 1;
                    unsigned int i38 = iArr3[i37];

                    for (unsigned int i39 = 0; i39 < 32; i39++) {
                        
                         int i40 = 1;
                        while (i40 > 0) {

                            unsigned int i41 = (i18 >>  2) & 3;
                            unsigned int i42 = 1;
                            while (i42 > 0) {
                                unsigned int i43 = i36 + i42;
                                unsigned int i44 = iArr3[i43 - 1];
                                i30 = iArr3[i43] - ((((i44 >>  5) ^ (i30 << 2)) + ((i30 >>  3) ^ (i44 << 4))) ^ ((i18 ^ i30) + (iArr3[(i42 & 3) ^ i41] ^ i44)));
                                iArr3[i43] = i30;
                                i42--;
                            }
                            unsigned int i45 = iArr3[i37];
                            i30 = iArr3[i36] - ((((i45 >>  5) ^ (i30 << 2)) + ((i30 >>  3) ^ (i45 << 4))) ^ ((i18 ^ i30) + (iArr3[(i42 & 3) ^ i41] ^ i45)));
                            iArr3[i36] = i30;
                            i18 -= -158018577;
                            i40 = i42 - 1;
                        }
                    }
                    for (unsigned int a = 0; a < 8; a++) {
                        bytes[a * 4] = (iArr3[a] >> 24) & 0xff;
                        bytes[a * 4 + 1] = (iArr3[a] >> 16) & 0xff;
                        bytes[a * 4 + 2] = (iArr3[a] >> 8) & 0xff;
                        bytes[a * 4 + 3] = (iArr3[a] >> 0) & 0xff;
                    }

                }
                
                bytes[i6] =  0xff&(t6 >> 8);
                bytes[i7] =  0xff&t6;
                bytes[i9] =  0xff&(s5 >> 8);
                bytes[i10] = 0xff&s5;
                bytes[i12] = 0xff&(s6 >> 8);
                bytes[i13] = 0xff&s6;
                bytes[i29] = 0xff&(t7 >> 8);
                bytes[i16] = 0xff&t7;
                
                unsigned int length2 = 32 / 4;
                unsigned int iArr4[8];
                unsigned int i46 = 0;
                for (unsigned int i47 = 0; i47 < length2; i47++) {
                    iArr4[i47] = (bytes[i46 + 3] & 255) | ((bytes[i46 + 2] & 255) << 8) | ((bytes[i46 + 1] & 255) << 16) | ((bytes[i46 + 0] & 255) << 24);
                    i46 += 4;
                }
                unsigned int i48 = i3 / 4;
                i5 = iArr4[i48];
                i4 = -1681272913;
                for (unsigned int i49 = 0; i49 < 33; i49++) {
                    unsigned int i50 = (i4 >>  2) & 3;
                    unsigned int i51 = 1;
                    while (i51 > 0) {
                        unsigned int i52 = i48 + i51;
                        unsigned int i53 = iArr4[i52 - 1];
                        if (i3 < 12) {
                            i5 = ((i5 ^ i4) + (iArr4[(i51 & 3) ^ i50] ^ i53)) ^ ((iArr4[i52] - ((i53 >>  5) ^ (i5 << 2))) + ((i5 >>  3) ^ (i53 << 4)));
                        }
                        else {
                            unsigned int i54 = iArr4[i52] - (((i5 ^ i4) + (i53 ^ iArr4[(i51 & 3) ^ i50])) ^ (((i53 >>  5) ^ (i5 << 2)) + ((i5 >>  3) ^ (i53 << 4))));
                            iArr4[i52] = i54;
                            i5 = i54;
                        }
                        i51--;
                    }
                    unsigned int i55 = iArr4[i48 + 1];
                    if (i3 < 12) {
                        i5 = ((i5 ^ i4) + (iArr4[i50 ^ (i51 & 3)] ^ i55)) ^ ((iArr4[i48] - ((i55 >>  5) ^ (i5 << 2))) + ((i5 >>  3) ^ (i55 << 4)));
                    }
                    else {
                        unsigned int i56 = iArr4[i48] - (((i5 ^ i4) + (iArr4[i50 ^ (i51 & 3)] ^ i55)) ^ (((i55 >>  5) ^ (i5 << 2)) + ((i5 >>  3) ^ (i55 << 4))));
                        iArr4[i48] = i56;
                        i5 = i56;
                    }
                    i4 -= -158018577;
                }
                for (unsigned int a = 0; a < 8; a++) {
                    bytes[a * 4] = (iArr4[a] >> 24) & 0xff;
                    bytes[a * 4 +1] = (iArr4[a] >> 16) & 0xff;
                    bytes[a * 4 + 2] = (iArr4[a] >> 8) & 0xff;
                    bytes[a * 4 + 3] = (iArr4[a] >> 0) & 0xff;
                }
                i3 += 8;
            }
            for (unsigned int a = 0; a < 32; a++) {
                if (bytes[a] != target[a]) {
                    return 0;
                }
            }

            cout << temp;
        

    }
    return 0;
}
int main()
{
    //88eec693
    string ans = "";
    unsigned char data[] = { 0xe6,0xa9,0xf,0xab,0x4c,0xf,0x95,0xa1,0xb8,0xc5,0xc4,0x65,0xb0,0xf1,0x75,0x75,0xc6,0xb4,0x3c,0x45,0x35,0xfc,0x7b,0xdc,0xd3,0x98,0x62,0x81,0xc1,0x10,0x53,0x84 };
    cout << "start" << endl;
    dfs(0, ans);

    cout << endl << "completed";
    return 0;
}
