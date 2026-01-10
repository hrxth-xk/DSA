class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        # lent=len(nums)
        # for i in range(lent):
        #     for j in range(i+1,lent):
        #         if nums[i]+nums[j]==target:
        #             return [i,j]                       O(n^2) complexity
        # seen=set()
        # for i in range(len(nums)):
        #     need=target-nums[i]
        #     if need in seen:
        #         return nums.index(need), i
        #     seen.add(nums[i])
        # return -1 # O(n^2) complexity because of .index()
        seen={}
        for i,n in enumerate(nums):
            need=target-n
            if need in seen:
                return [seen[need], i]
            seen[n]=i
        return []
