#include <stdio.h>

int main(int argc, char const *argv[])
{
    int arr[64]={
			116,
			94,
			80,
			127,
			49,
			71,
			101,
			106,
			115,
			97,
			57,
			83,
			94,
			109,
			58,
			98,
			75,
			86,
			40,
			100,
			61,
			123,
			110,
			57,
			123,
			89,
			86,
			121,
			123,
			104,
			97,
			60,
			86,
			74,
			86,
			112,
			103,
			103,
			124,
			111,
			86,
			99,
			107,
			56,
			93,
			71,
			96,
			106,
			69,
			49,
			112,
			59,
			103,
			124,
			90,
			65,
			71,
			114,
			79,
			93,
			74,
			90,
			90,
			71
		};
    int *p = arr;
  
    int tmp;
    for (int i = 0; i < 32; i++)
    {
        tmp = arr[i];
        arr[i] = arr[63 - i];
        arr[63 - i] = tmp;
    }
      for (int i = 0; i <64 ; i++)
    {
        *(p + i) ^= 9;
        printf("%c",*(p+i));
    }
    
    return 0;
}
