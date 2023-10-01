/**
 * @param {string} coordinates
 * @return {boolean}
 */
var squareIsWhite = function(coordinates) {
    const column = coordinates.charCodeAt(0) - 96; // Transforma toda a string da coordinates em char ASCI, removendo também os 96 chars
    const row = parseInt(coordinates[1]); // Parses just the Int values

    return (column + row) % 2 !== 0;
};