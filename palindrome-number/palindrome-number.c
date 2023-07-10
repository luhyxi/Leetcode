#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

long long int rev_Number(long long int x) {
    long long int rev_x = 0; 
    long long int abs_x = llabs(x);
    while (abs_x != 0) {
        long long int i = abs_x % 10;
        rev_x = rev_x * 10;rev_x = rev_x + i;
        abs_x = abs_x / 10;
    } return rev_x;
}


bool isPalindrome(int x){
    int y = rev_Number(x);
    if(y != x) return false;
    else return true;
}