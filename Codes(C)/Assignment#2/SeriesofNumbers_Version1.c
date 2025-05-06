#include <stdio.h>

int main()
{
// Initialization of Variables.
    int sum, minimum, maximum, cntr, length;
    float mean, fsum;

// The Array Note: You can add more numbers into this array if you want.
    int number[] = {10, 12, 10, 14};

// Assignment of Values
    minimum = number[0];
    maximum = 0;
    sum = 0;
    length = sizeof(number) / sizeof(number[0]);

// Loops and calculations to solve for sum, mean, minimum, and maximum values.
    for(cntr = 0; cntr < length; cntr++)
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
    mean = fsum / length;

// Output
    printf("The sum is %d,\n", sum);
    printf("The mean is %.2f,\n", mean);
    printf("The minimum is %d,\n", minimum);
    printf("The maximum is %d", maximum);
}