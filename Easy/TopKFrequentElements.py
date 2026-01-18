from collections import Counter
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        # seen={}
        # for i in range(len(nums)):
        #     seen[nums[i]]=seen.get(nums[i],0)+1
        # sor=dict(sorted(seen.items(), key=lambda x:x[1], reverse=True))
        # return list(sor.keys())[:k] O(nlogn)
        n=len(nums)
        counter=Counter(nums)
        bucket=[0]*(n+1)
        for num,freq in counter.items():
            if bucket[freq]==0:
                bucket[freq]=[num]
            else:
                bucket[freq].append(num)
        ret=[]
        for i in range(n,-1,-1):
            if bucket[i]!=0:
                ret.extend(bucket[i])
            if len(ret)==k:
                break
        return ret
