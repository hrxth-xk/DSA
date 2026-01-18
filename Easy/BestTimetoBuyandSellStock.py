class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        prof=0
        min=prices[0]
        for i in prices:
            if i<min:
                min=i
            elif i-min>prof:
                prof=i-min
        return prof
        
        
        
        
        
        
        
        
        # prof=0
        # i=0
        # j=1
        # while i<len(prices) and j<len(prices):
        #     if prices[j]>prices[i] and (prices[j]-prices[i])>prof:
        #         print(prices[i],prices[j])
        #         prof=prices[j]-prices[i]
        #         j+=1
        #         if j==len(prices):
        #             i+=1
        #             j=i
        #     else:
        #         j+=1
        #         if j==len(prices):
        #             i+=1
        #             j=i
        # return prof


        # for i in range(len(prices)):
        #     for j in range(i+1,len(prices)):
        #         if prices[j]>prices[i] and (prices[j]-prices[i])>prof:
        #             prof=prices[j]-prices[i]
        # return prof
