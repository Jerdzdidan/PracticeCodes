#include <stdio.h>

int main()
{
    int sum, minimum, maximum, cntr, n;
    int number[n];
    float mean, fsum;

    printf("Enter the number of elements in the array: ");
    scanf("%d", &n);

    printf("Enter %d number:\n", n);
    for(cntr = 0; cntr < n; cntr++)
    {
        scanf("%d", &number[cntr]);
    }
    
    minimum = number[0];
    maximum = 0;
    sum = 0;
    
    for(cntr = 0; cntr < n; cntr++)
    {
        if(number[cntr] < minimum)
        {
            minimum = number[cntr];
        }
        if(number[cntr] > maximum)
        {
            maximum = number[cntr];
        }
        sum += number[cntr];
    }

    fsum = sum;
    mean = fsum / n;

    printf("The sum is %d,\n", sum);
    printf("The mean is %.2f,\n", mean);
    printf("The minimum is %d,\n", minimum);
    printf("The maximum is %d", maximum);
}