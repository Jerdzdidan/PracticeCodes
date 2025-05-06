from plates import is_valid

def test_1():
    assert is_valid("cs50") == True

def test_2():
    assert is_valid("cs50000") == False

def test_3():
    assert is_valid("c50s") == False

def test_4():
    assert is_valid("01234") == False

def test_5():
    assert is_valid("VAIN50") == True
