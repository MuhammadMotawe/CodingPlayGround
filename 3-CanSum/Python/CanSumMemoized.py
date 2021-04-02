'''
Determines if we can get the targetSum by adding any of the numbers in nums
-Repeating allowed
-No negative numbers expected
'''
def CanSum(targetSum, nums, memo = {}):
    if(targetSum in memo): return memo[targetSum]
    if(targetSum == 0): return True
    if(targetSum < 0): return False
    
    for num in nums:
        remainder = targetSum - num
        if(CanSum(remainder, nums, memo)):
            memo[remainder] = True
            return True

    memo[targetSum] = False
    return False


print(CanSum(300, [7,14]))
