#include <stdio.h>
#include <stdlib.h>

void finally(char *input) {
    int x[] = {0x0E, 0x0D, 0x9, 0x6, 0x13, 0x5, 0x58, 0x56, 0x3E, 0x6, 0x0C, 0x3C, 0x1F, 0x57, 0x14, 0x6B, 0x57, 0x59,0x0D};
    int i, result = 0;
    char Buffer[] = "hahahaha_do_you_find_me?";

    for (i = 0; i <=18; i++) {
       for (int edx = 32; edx <= 126; edx++)
       {
          char eax = Buffer[i];
          result = (eax ^ edx);
          if (result==x[i])
          {
              printf("%c",edx);
              break;
          }
          
       }
       
    }

    
}

int main() {
    char input[] = "flag{aaaaaaaaaaaaa}";
    finally(input);

    return 0;
}
