#include <stdio.h>
int main(int argc, char const *argv[])
{
    char a = 0xA1;
    char b = 0xc0;
    //77
    char c = (~(~0x61 & ~0x77)) & ~0x61;
    //E3 ~E3=1c ~16=E9 ~(E3&16)=FD ~(~E3 & ~16)=F7 FD&F7=F5
    //c1 ~c1=3E ~F5=0A ~(~C1 & ~F5)&~C1=34  
    //75 ~75=8A ~34=CB  ~(~75 & ~34) & ~34 =41
    //AB ~41=BE ~AB=54  ~(~41 & ~AB) =
    printf("%x",c);
    return 0;
}
/*flag{aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa}

F1 F2 F3 F4 F5 F6 F7 F8   addr
//取了DE 和 B8
按位取反DE ,~DE & ~DE,按位取反B8,~B8 & ~B8,DE&B8=98 ~DE & ~B8 =01 ~01=FE ~98=67 FE&67=66 ~66=99
      DE DE B8 DE B8 66
      input = 61
      77 E3
~77=88 ~input=9E  (~(~input & ~77))&~input=16 */