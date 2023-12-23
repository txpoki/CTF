#include <stdio.h>
int main(int argc, char const *argv[])
{
    int k = 1;
    for (int i = 127; i < 256; i++)
    {
        printf("%d ", i);
        if (!(k%25))
        {
            printf("\n");
        }
        k++;
        
    }
    
    return 0;
}
