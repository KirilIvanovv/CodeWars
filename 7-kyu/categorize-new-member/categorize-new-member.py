def open_or_senior(data):
    result = []
    for a, b in data:
        if a >= 55 and b > 7:
            result.append("Senior")
        else: result.append("Open")
    return result