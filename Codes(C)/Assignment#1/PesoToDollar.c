#include <stdio.h>

int main(){
//Initialization of Variables
  int peso;
  float dollar;

//Input from user
  printf("Input Peso: ");
  scanf("%d", &peso);

//Process
  dollar = peso / 56.65;

//Output
  printf("Dollar Value: $%0.2f\n",dollar);
}