class Solution:
    def findClosestNumber(self, nums: List[int]) -> int:
        res=float('+inf')
        sm=0
        for i in nums:
            dist=abs(i)
            if dist<res:
                res=dist
                sm=i
            if dist==res:
                if i>sm:
                    sm=i
        return sm

