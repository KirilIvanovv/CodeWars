import math
​
def solution(lst):
    r = lst[0]
    for x in lst[1:]:
        r = math.gcd(r, x)
    return r * len(lst)