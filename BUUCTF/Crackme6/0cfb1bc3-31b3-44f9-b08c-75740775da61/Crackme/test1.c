#include <stdio.h>
int main(int argc, char const *argv[])
{
    //6B8
    int flag = 0,what;
    char input[9] = "000000000";
    char wh[9] = { 0x33, 0x21, 0x22, 0x21, 0x35, 0x7C, 0x62, 0x65, 0x6E};
    int enc[9] = {0};

for (int  i = 0; i < 9; i++){
    
    for (int  k = 32; k <=126 ; k++)
    {
          enc[i] = (wh[i] ^ k) - 65;
        if (enc[i]>1)
        {
            printf("%d ",k);
            printf("enc[i]=%d ",enc[i]);
        }
    }
    printf("\n");
}
   
    //for (int i = 0; i < 8; i++)
    //{
    //    if (enc[i]>=enc[i+1])
    //    {
    //        flag = 1;
    //        break;
    //    }
    //    
    //}
    //if (!flag)
    //{
    //    what = 1;
    //    for (int i = 0; i < 9; i++)
    //    {
    //        what *= enc[4 * i];
    //    }
    //    what = 100 / (223092870 - what);
    //    }
    
    //pediy2016
    
    
    return 0;
}
