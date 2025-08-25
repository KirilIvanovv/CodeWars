def find_average(numbers):
    sum = 0
    for i in numbers:
        sum += i
    return sum / len(numbers) if numbers else 0
​