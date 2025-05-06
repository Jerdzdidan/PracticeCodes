#include <stdio.h>

int main() {
  
//Initialization of Variables
  int feet, inches;
  float centimeter;

//Input from user
  printf("Input feet: ");
  scanf("%d", &feet);
  printf("Input inches: ");
  scanf("%d", &inches);

//Process
  centimeter = (inches + (feet * 12)) * 2.54;

//Output
  printf("Centimeter Value: %.2fcm\n", centimeter);
}