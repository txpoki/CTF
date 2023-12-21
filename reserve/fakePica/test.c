#include <stdio.h>
int main(int argc, char const *argv[]){
    char in[32] = {-114, 95, -37, 127, -110, 113, 41, 74, 40, 73, 19, 124, -57, -88, 39, -116, -16, -75, -3, -45, -73, -6, -104, -6, -78, 121, 110, 74, -90, -47, -28, -28};
    //picacomic@gmail.com
    char inr[16] = {-40, 26, 95, -49, -40, -123, 72, -90, -100, -41, 122, -4, 25, -101, -58, 116};
    //picacomic
    for (int  i = 0; i < 16; i++)
    {
        printf("%x",inr[i]& 0xff);
    }
    //flag{picacomic@gmail.com+picacomic}

    return 0;
}

