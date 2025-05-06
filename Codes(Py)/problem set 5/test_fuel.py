from fuel import convert

def test_1():
    assert convert(100/100) == "Error"

def test_2():
    assert convert("100/100") == "F"
    assert convert("99/100") == "F"