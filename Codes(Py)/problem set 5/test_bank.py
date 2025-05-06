from bank import greet

def test_hello():
    assert greet("hello") == 0

def test_h():
    assert greet("hey") == 20

def test_default():
    assert greet("ohayo") == 100