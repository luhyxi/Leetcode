/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function(candidates, target) {
    const result = [];

    function backtrack(remaining, start, currentCombination) {
        if (remaining === 0) {
            result.push([...currentCombination]);
            return;
        }
        if (remaining < 0) {
            return;
        }
        for (let i = start; i < candidates.length; i++) {
            currentCombination.push(candidates[i]);
            backtrack(remaining - candidates[i], i, currentCombination);
            currentCombination.pop();
        }
    }

    backtrack(target, 0, []);
    return result;
};
