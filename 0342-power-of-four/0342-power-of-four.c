int isPowerOfFour(int n) {
    if (n <= 0) {
        return false;
    }

    long nAbs = abs(n);
    while (nAbs%4 == 0){
        nAbs = nAbs / 4;
    }
    return (nAbs == 1) ? 1 : 0;
};