#include <stdio.h>

int main(){

    int number, cntr1, cntr2, cntr3;

    printf("Enter a odd number: ");
    scanf("%d", &number);

    cntr1 = 1;
    
    while(cntr1 <= number)
    {
        cntr2 = 1;
        cntr3 = 1;
        while(cntr2 <= (number - cntr1)/2)
        {
            printf(" ");
            cntr2++;
        }
        while(cntr3 <= cntr1)
        {
            printf("#");
            cntr3++;
        }
        printf("\n");
        cntr1+=2;
    }

    cntr1 = number - 2;
    while(cntr1 >= 1)
    {
        cntr2 = 1;
        cntr3 = 1;
        while(cntr2 <= (number - cntr1)/2)
        {
            printf(" ");
            cntr2++;
        }
        while(cntr3 <= cntr1)
        {
            printf("#");
            cntr3++;
        }
        printf("\n");
        cntr1-=2;
    }


    
}