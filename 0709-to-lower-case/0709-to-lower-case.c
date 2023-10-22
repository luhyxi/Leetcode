#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char * toLowerCase(char * s){
    for (int i = 0; s[i]; i++){
        s[i] = tolower(s[i]);
    }
    return s;
}