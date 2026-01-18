class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        tp=0
        i=0
        while i<len(s) and tp<len(t):
            if s[i]==t[tp]:
                i+=1
                tp+=1
            else:
                tp+=1
        if i==len(s):
            return True
        else:
            return False
            
        
        
        
        
        
        
        # for i in range(len(t)):
        #     if[s[i]]==t[i]:
        #         one+=1
        #         two+=1
        #         sr+=s[i]
        #     else:
        #         two+=1
        # if s==sr:
        #     return True
        # else:
        #     return False
                
