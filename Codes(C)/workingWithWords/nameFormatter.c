#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main()
{
    char name[21];
    char buffer[80];
    int counter;

    printf("\nWhat is your name?: ");
    fgets(buffer, sizeof(buffer), stdin);

    if(strlen(buffer) > 20)
    {
        printf("Sorry. That name is too long.");
    }
    else
    {
        strcpy(name, buffer);
        name[0] = toupper(name[0]);
        counter = 1;
        while(name[counter] != '\0')
        {
            if(name[counter - 1] == ' ')
            {
                name[counter] = toupper(name[counter]);
            }
            else
            {
                name[counter] = tolower(name[counter]);
            }
            counter++;
        }
        printf("\nHello, %s", name);
        
    }


    
}