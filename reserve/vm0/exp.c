#include <stdio.h>
int main(int argc, char const *argv[])
{
    char a = 'a',s='s';
    char str[] = "Fz{aM{aM|}fMt~suM !!";
    for (int i = 0; i < 20; i++) // 修改了这一行
    {
        str[i]^=18;
        
    }
    printf("%s",str);

    return 0;
}
