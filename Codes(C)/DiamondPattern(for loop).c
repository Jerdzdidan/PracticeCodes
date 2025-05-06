#include <stdio.h>

int main(){


    int integer, cntr1, cntr2;

    printf("Enter odd number: ");
    scanf("%d", &integer);

    for(cntr1 = 1; cntr1 <= integer; cntr1+=2)
    {
        for(cntr2 = 1; cntr2 <= (integer - cntr1) / 2; cntr2++)
        {
            printf(" ");
        }
        for(cntr2 = 1; cntr2 <= cntr1; cntr2++)
        {
            printf("*");
        }
        printf("\n");
    }

    for(cntr1 = integer - 2; cntr1 >= 1; cntr1-=2)
    {
        for(cntr2 = 1; cntr2 <= (integer - cntr1) / 2; cntr2++)
        {
            printf(" ");
        }
        for(cntr2 = 1; cntr2 <= cntr1; cntr2++)
        {
            printf("*");
        }
        printf("\n");
    }

    
}