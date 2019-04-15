def xor(a, b):
    if (a and b !=True) and (a or b == True):
        return True
    else:
        return False

print(xor(True, False))
print(xor(True, True))
print(xor(False, False))




