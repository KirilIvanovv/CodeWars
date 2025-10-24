def nth_fib(n):
    if(n == 1): return 0
    if(n == 2): return 1
    
    a = 0
    b = 1    
    
    for x in range(3, n + 1):
        temp = a + b
        a = b
        b = temp
        
    return temp
        