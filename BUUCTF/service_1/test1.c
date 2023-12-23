#include <stdio.h>
int main(int argc, char const *argv[])
{
    //6B8
    int flag = 0,what;
    char input[13] = "1111111111111";
    char wh[9] = { 0x33, 0x21, 0x22, 0x21, 0x35, 0x7C, 0x62, 0x65, 0x6E};
    int enc[9] = {0};
    for (int  i = 0; i < 9; i++)
    {
        enc[i] = (wh[i] ^ input[i]) - 65;
    }
    if (enc[0]<=1)
    {
        flag = 1;
    }
    for (int i = 0; i < 8; i++)
    {
        if (enc[i]>=enc[i +1])
        {
            flag = 1;
            break;
        }
        
    }
    if (!flag)
    {
        what = 1;
        for (int i = 0; i < 9; i++)
        {
            what *= enc[4 * i];
        }
        what = 100 / (223092870 - what);
        }
    
    
    
    
    return 0;
}
