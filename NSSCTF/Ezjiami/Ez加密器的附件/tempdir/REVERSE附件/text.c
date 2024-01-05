#include <stdio.h>
int main(int argc, char const *argv[])
{
    int len_cp, len, v3=-40;
    for (int i=1; i <= 100;i++)
    {
        v3 = -40;
        len = i;
        do
        {
            len_cp = len;
            len ^= v3;
            v3 = 2 * (v3 & len_cp);
        } while (v3);
        if (!len)
        {
            printf("%d", i);
            break;
        }
    }
    return 0;
}
