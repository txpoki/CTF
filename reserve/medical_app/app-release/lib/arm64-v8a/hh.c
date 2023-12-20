#include<stdio.h>
#include<stdint.h>
#define DELTA 0x9F5776B6
#define MX (((z>>5^y<<2) + (y>>3^z<<4)) ^ ((sum^y) + (key[(p&3)^e] ^ z)))


unsigned int v38[9] ={1759876926, 3255595879, 2561659931, 4266368482, 27637259, 1027003974, 3687611311, 2688634624, 1982654234};
unsigned int key[4]={0x00000001,0x00000010,0x00000100,0x00001000};
 
void xxtea(uint32_t *v, int n, uint32_t const key[4])
{
    int i = 0;
    uint32_t y, z, sum;
    unsigned p, rounds, e;
	if (n < -1)      /* Decoding Part */
    {
        n = -n;
        rounds = 6 + 52/n;
        sum = rounds*DELTA;
        y = v[0];
        do
        {
            printf("0x%08x\n",sum);
            e = (sum >> 2) & 3;
            printf("%d\n", e);
            for (p=n-1; p>0; p--)
            {
                z = v[p-1];
                y = v[p] -= MX;
            }
            z = v[n-1];
            y = v[0] -= MX;
            sum -= DELTA;
            
            i++;
        }
        while (--rounds);
        //printf("%d", i);
    }
}

int main()
{
	xxtea(v38, -9, key);
	for(int i=0;i<9;i++)
	{
		//printf("0x%x",v38[i]);
		//printf("0x%x,0x%x,0x%x,0x%x,",*((char *)&v38[i]+0)&0xff,*((char *)&v38[i]+1)&0xff,*((char *)&v38[i]+2)&0xff,*((char *)&v38[i]+3)&0xff);
	}
	return 0;	
}  
