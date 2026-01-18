class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x==0:
            return True
        elif (x<0) or (x%10==0):
            return False
        p=x
        lent = len(str(x))
        s=0
        for i in range(0,lent):
            a=p%10
            s=(s*10)+a
            p=p//10
        if s==x:
            return True
        else:
            return False        
