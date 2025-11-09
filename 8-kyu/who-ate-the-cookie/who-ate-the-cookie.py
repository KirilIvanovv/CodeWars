def cookie(x):
    if isinstance(x, str):
        who = "Zach"
    elif isinstance(x, (int, float)) and not isinstance(x, bool):
        who = "Monica"
    else:
        who = "the dog"
​
    return f"Who ate the last cookie? It was {who}!"