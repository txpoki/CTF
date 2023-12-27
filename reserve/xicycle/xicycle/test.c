#include <stdio.h>
int pro;
int fuc(){
    static int a;
    pro++;
    return a;
}
int main(int argc, char const *argv[])
{
    int a[2][2]= { {1,3} , , };;
    double b[2][2]={1.1,2.2,3.5};
    return 0;
}
