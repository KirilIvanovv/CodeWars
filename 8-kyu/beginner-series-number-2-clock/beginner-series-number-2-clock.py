def past(h, m, s):
    result = 0
    result += s * 1000
    result += m * 60 * 1000
    result += h * 3600 * 1000
    return result