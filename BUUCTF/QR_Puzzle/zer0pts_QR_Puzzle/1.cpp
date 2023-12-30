#include <cstdio>
#include <cstdlib>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <cstring>
using namespace std;
char buf_key[625 * 20];
char buf_encrypt[30][300];
int key[700][4];
int work2(int l, int r)
{
    int p = 1, res = 0;
    while (r >= l)
    {
        res += (buf_key[r] - '0') * p;
        p *= 10;
        r--;
    }
    return res;
}
void work(int p, int l, int r)
{
    key[p][3] = buf_key[l] - '0';
    l += 3;
    int k = l;
    while (buf_key[++k] != ',')
        ;
    key[p][1] = work2(l, k - 1);
    l = k + 1;
    key[p][2] = work2(l, r - 1);
    //printf("%d#(%d,%d)\n", key[p][3], key[p][1], key[p][2]);
}
int main()
{
  
    return 0;
    int fd = open("./key", O_RDWR);
    if (fd == -1)
    {
        printf("open error\n");
        exit(0);
    }
    read(fd, buf_key, 625 * 20);
    int len = strlen(buf_key);
    buf_key[len] = '\n';
    buf_key[len + 1] = '\0';
    //printf("%s", buf_key);
    close(fd);
    int last = 0, num = 0;
    for (int i = 0; i < strlen(buf_key); i++)
    {
        if (buf_key[i] == '\n')
        {
            work(num++, last, i - 1);
            last = i + 1;
        }
        if (i == strlen(buf_key) - 3)
            break;
    }
    // read key    end
    fd = open("./encrypted.qr", O_RDWR);
    if (fd == -1)
    {
        printf("open error\n");
        exit(0);
    }
    for (int i = 0; i < 25; i++)
    {
        read(fd, buf_encrypt[i], 26);
        printf("%s", buf_encrypt[i]);
    }
    printf("\n\n");
    close(fd);
    for (int i = 0; i < 625; i++)
    {
        int key1 = key[i][3];
        int key2 = key[i][1];
        int key3 = key[i][2];
        int p1, p2;
        char *v4;
        char *v5;
        if (key1 == 1)
        {
            p1 = key2 + 1;
            p2 = key3;
            goto LABEL_4;
        }
        if (key1 <= 1)
        {
            if (!key1)
            {
                p1 = key2 - 1;
                p2 = key3;
                goto LABEL_4;
            }
            goto LABEL_11;
        }
        if (key1 != 2)
        {
            p2 = key3 + 1;
            p1 = key2;
            if (key1 == 3)
                goto LABEL_4;
        LABEL_11:
            p2 = key3;
            p1 = key2;
            goto LABEL_4;
        }
        p2 = key3 - 1;
        p1 = key2;
    LABEL_4:

        v4 = buf_encrypt[key3];
        v5 = buf_encrypt[p2];
        *(char *)(v4 + key2) += *(char *)(v5 + p1);
        *(char *)(p1 + v5) = *(char *)(v4 + key2) - *(char *)(p1 + v5);
        *(char *)(key2 + v4) -= *(char *)(v5 + p1);
        /*
        *(char *)(key2 + v4) += *(char *)(v5 + p1);
        *(char *)(p1 + v5) = *(char *)(v4 + key2) - *(char *)(p1 + v5);
        *(char *)(v4 + key2) -= *(char *)(v5 + p1);
        */
    }
    for (int i = 0; i < 25; i++)
    {
        printf("%s", buf_encrypt[i]);
    }
    return 0;
}