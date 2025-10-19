def expanded_form(num):
    numStr = str(num)
    result = []
    zero = len(numStr) - 1
    
    for ch in numStr:
        if ch != '0':
            part = ch + "0" * zero
            result.append(part)
        zero -= 1
    
    return " + ".join(result)