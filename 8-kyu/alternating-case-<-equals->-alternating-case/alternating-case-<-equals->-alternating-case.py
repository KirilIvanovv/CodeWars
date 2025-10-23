def to_alternating_case(string):
    result = ""
    for x in string:
        if x == x.lower():
            result += x.capitalize()
        else: result += x.lower()
    return result
​