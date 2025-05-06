#include <stdio.h>

int main() {
    
// Initialization of Variables
  int years, months, weeks, days;
 
//Input from user
  printf("Input number of days: ");
  scanf("%d", &days);
  
//Processes of conversions
  years = days / 365;
  days = days - (years * 365);

  months = days / 30;
  days = days - (months * 30);

  weeks = days / 7;
  days = days - (weeks * 7);
  
//Output
  printf("\n%d Years, %d Months, %d Days", years, months, weeks,  days);
}