#include <stdio.h>

int main(){
// Initialization of Variables
    int number, cntr1, cntr2;

// User input
    printf("Enter a Number from 1-9: ");
    scanf("%d", &number);
    
// Loops for creating the display
    for(cntr1 = 1; cntr1 <= number; cntr1 += 1)
    {
        for(cntr2 = 1; cntr2 <= number - cntr1; cntr2++)
        {
            printf(" ");
        }
        for(cntr2 = 1; cntr2 <= cntr1; cntr2++)
        {
            printf("%d", cntr1);
            printf(" ");
        }
        
        printf("\n");
    }

}