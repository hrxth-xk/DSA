from collections import defaultdict
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # seen={}
        # for i in strs:
        #     sor="".join(sorted(i))
        #     seen.setdefault(sor,[]).append(i)
        #     li=[]
        # return list(seen.values())
        seen=defaultdict(list)
        for i in strs:
            count=[0]*26
            for c in i:
                count[ord(c)-ord('a')]+=1
            seen[tuple(count)].append(i)
        return list(seen.values())
