def is_valid_train_arrangement(before, after):
    if len(before) != len(after):
        return False
    
    b_trains =[(c, i) for i, c in enumerate(before) if c in "<>"]
    a_trains =[(c, i) for i, c in enumerate(after) if c in "<>"]
    
    if[c for c, _ in b_trains] != [c for c, _ in a_trains]:
        return False
    
    for(c, i_before), (_, i_after) in zip(b_trains, a_trains):
        if c == '>' and i_after < i_before:
            return False
        if c == '<' and i_after > i_before:
            return False
    return True