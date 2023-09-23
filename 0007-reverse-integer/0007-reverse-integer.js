/**
 * @param {number} x
 * @return {number}
 */
var reverse = function(x) {
    const upperBound = 2147483647;
    const lowerBound = -2147483648;

    let numStr = String(x);

    if (numStr[0] === '-') {
        const reversed = '-' + numStr.slice(1).split('').reverse().join('');
        return (reversed >= lowerBound) ? reversed : 0;
    } else {
        const reversed = numStr.split('').reverse().join('');
        return (reversed <= upperBound) ? reversed : 0;
    }
};
