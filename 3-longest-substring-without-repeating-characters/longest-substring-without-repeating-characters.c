#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAXLEN 50000

int lengthOfLongestSubstring(char * s){
    if (*s == '\0') return 0;

    int s_Len = strlen(s); int i;
    int size_Sub = 0; int Array_s[MAXLEN];
    int char_set[128];

    
    // Alocar as substrings (como int) dentro de um array
    int n = 0;
    memset(char_set, 0, sizeof(char_set));
    char *start = s, *end = s;
    for (i = 0; i < s_Len; i++){
        if (char_set[*end] == 0) {
            char_set[*end] = 1;
            size_Sub = end - start + 1;} else {
                while(*start != *end) {
                    char_set[*start] = 0; start++;}
                start ++;}
        Array_s[n] = size_Sub;
        n++; end++;}

    // Encontra a maior Substring
    int max = Array_s[0];
    for (i = 1; i < n; i++){
        if (Array_s[i] > max){
            max = Array_s[i];}
        } return max;
}