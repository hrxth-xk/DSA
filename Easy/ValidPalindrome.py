class Solution:
    def isPalindrome(self, s: str) -> bool:
        li=list(s)
        l=0
        r=len(li)-1
        while l<r:
            while l<r and not li[l].isalnum() :
                l+=1
            while l<r and not li[r].isalnum():
                r-=1
            if li[l].lower() !=li[r].lower():
                return False
            l+=1
            r-=1
        return True
