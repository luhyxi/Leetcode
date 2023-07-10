class Solution(object):
    def twoSum(self, nums, target):
        table = {}
        
        for i in range(len(nums)):         #"Para cada INDEX no RANGE de NUMEROS"
            diff = target - nums[i]
            if diff in table:
                return (i, table[diff])
            table[nums[i]] = i
        return