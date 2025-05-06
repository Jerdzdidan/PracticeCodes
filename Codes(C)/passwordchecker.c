#include <stdio.h>
#include <string.h>
#include <ctype.h>



int password()
{

    int ltrCntr, tryCntr;
    char userWord[11];

    tryCntr = 0;
    while(1==1)
    {

        printf("What is your password? ");
        scanf("%s", userWord);

        ltrCntr = 0;

        while(ltrCntr < strlen(userWord))
        {
            userWord[ltrCntr] = toupper(userWord[ltrCntr]);
            ltrCntr++;
        }
        
        if(strlen(userWord) > 0 && strlen(userWord) <= 11)
        {
            if(strcmp(userWord, "OPENSESAME") == 0)
            {
                return 1;
            }
            else
            {
                tryCntr++;
                if(tryCntr == 3)
                {
                    return 0;
                }
            }
        }
        else
        {
            printf("Password must be atleast 11 characters long.\n");
            return 0;
        }
        
    }

    
    
}


int main()
{

    if(password() == 1)
    {
        printf("Correct password. You may begin the program.");
    }
    else
    {
        printf("Wrong Password");
    }

}
