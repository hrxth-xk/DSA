class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        # n=len(nums)
        # pre=[0]*(n)
        # pos=[0]*(n)
        # curprod=1
        # fin=[]
        # pre[0]=curprod
        # for i in range(len(nums)-1):
        #     curprod*=nums[i]
        #     pre[i+1]=curprod
        # curprod=1
        # pos[-1]=curprod
        # num=-2
        # for j in range(len(nums)-1):
        #     curprod*=nums[num+1]
        #     pos[num]=curprod
        #     num-=1
        # for i in range(len(nums)):
        #     fin.append(pre[i]*pos[i])

        # return fin
        # More optimised Solution


        pre=1
        post=1
        n=len(nums)
        ans=[1]*n
        for i in range(n):
            ans[i]=pre
            pre*=nums[i]
        for j in range(n-1,-1,-1):
            ans[j]*=post
            post*=nums[j]
        return ans
