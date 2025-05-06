#include <stdio.h>
#include <string.h>

int main()
{
    char name[16];
    int cntr;

    cntr = 0;
    strcpy(name, "Amadeus");

    while(name[cntr] != 0)
    {
        printf("\nLetter %d of %s is %c.", cntr+1, name,name[cntr]);
        cntr++;
    } 
}