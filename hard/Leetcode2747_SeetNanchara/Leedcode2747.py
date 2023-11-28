class Solution(object):
    def numberOfWays(self, corridor):
        pList = []
        
        countS = 0
        countP = 0
        
        totalS = 0
        
        for i in corridor:
            if(i == "S"): #假如是沙發
                countS += 1  #連續沙發 +1
                totalS += 1
            elif(i == "P"): #假如是花盆
                if(countS == 2):
                    countP += 1
            if(countS == 3): #假如沙發等於3(有下一組過來)
                pList.append(countP + 1)
                countS = 1
                countP = 0
            
        result = 1;
        
        if(totalS % 2 == 1):
            return 0
        
        #print(pList)
        if(len(pList) == 0):
            if(countS == 2):
                return 1
            else:
                return 0
            
        
        for temp in pList:
            result *= temp
        
        return result % (10**9 + 7)