class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        li={}
        for i in s:
            # if i in li:
            #     li[i]+=1
            # else:
            #     li[i]=1
            li[i]=li.get(i,0)+1
        for i in t:
            if i in li:
                li[i]-=1
            else:
                return False

        for i in li:
            if li[i]==0:
                continue
            else:
                return False
        return True
            
