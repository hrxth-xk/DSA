class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        li=[]
        left=0
        right=len(nums)-1
        while left<=right:
            if abs(nums[left])>abs(nums[right]):
                li.append(nums[left]**2)
                left+=1
            else:
                li.append(nums[right]**2)
                right-=1
        li.reverse()
        return li
        
