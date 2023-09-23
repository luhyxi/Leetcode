/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    var countMap = {};
    
    for (let num of nums) {
        if (countMap[num]) {
            countMap[num]++;
        } else {
            countMap[num] = 1;
        }
    }   for (let num in countMap) {
        if (countMap[num] === 1) {
            return Number(num); // Convert num to a number type
        }
    }
}