class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:

        window_sum = sum(nums[0:k]) #first Window
        best = window_sum
        # We can initiate the count with the very first sum, starting at the index of 0
        for i in range(1, len(nums) - k + 1): #We can start from the first index 
            window_sum = window_sum - nums[i - 1] + nums[i + k - 1] # We are basically using this line to iterate to the next indices, everytime we slide the counter
            best = max(best, window_sum)

        return best / k           


        