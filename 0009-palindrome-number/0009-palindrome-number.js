/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    if (x < 0) return false;

    let original = x;
    let reversed = 0;
    while (x > 0) {
        const pop = x % 10;
        x = Math.trunc(x / 10);
        reversed = reversed * 10 + pop;
    } return original === reversed;
};