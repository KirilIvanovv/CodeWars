def basic_op(operator, value1, value2):
    
    match operator:
        case "+":
            result = value1 + value2
        case "-":
            result = value1 - value2
        case "/":
            result = value1 / value2
        case "*":
            result = value1 * value2
            
    return result
    