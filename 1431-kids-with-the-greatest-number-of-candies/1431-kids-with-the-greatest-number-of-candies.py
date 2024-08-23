class Solution(object):
    def kidsWithCandies(self, candies, extraCandies):
        new_array = []
        largest_value = max(candies)
        for x in candies:
            if x+extraCandies >= largest_value: new_array.append(True)
            else: new_array.append(False)
        return new_array