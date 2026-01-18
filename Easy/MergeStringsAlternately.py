class Solution:
    def mergeAlternately(self, word1: str, word2: str) -> str:
    
        i,j=0,0
        A,B=len(word1),len(word2)
        s=[]
        word=1
        while i<A and j<B:
            if word==1:
                s.append(word1[i])
                i+=1
                word=2
            else:
                s.append(word2[j])
                j+=1
                word=1
        while i<A:
            s.append(word1[i])
            i+=1
        while j<B:
            s.append(word2[j])
            j+=1
        return "".join(s)


       















         # if len(word1)>len(word2):
        #     n=len(word2)
        #     for i in range(n):
        #         fin+=word1[i]
        #         fin+=word2[i]
        #         if i==n-1:
        #             fin+=word1[i+1:]
        # elif len(word2)>len(word1):
        #     n=len(word1)
        #     for i in range(n):
        #         fin+=word1[i]
        #         fin+=word2[i]
        #         if i==n-1:
        #             fin+=word2[i+1:]
        # else:
        #     n=len(word1)
        #     for i in range(n):
        #         fin+=word1[i]
        #         fin+=word2[i]
        # return fin
