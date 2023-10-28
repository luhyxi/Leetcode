char *restoreString(char *s, int *indices, int indicesSize) {
    char *newStr = (char *)malloc((indicesSize + 1) * sizeof(char));

    for (int i = 0; i < indicesSize; ++i) {
        newStr[indices[i]] = s[i];
    }

    newStr[indicesSize] = '\0';  // Null-terminate the new string.

    return newStr;
}
