from twttr import twttr

def test_twttr1():
    assert twttr("Jerdan") == "Jrdn"
    assert twttr("superman") == "sprmn"
    assert twttr("enigma") == "ngm"
    assert twttr("BONUS") == "BNS"

def test_twttr2():
    assert twttr("twitter") == "twttr"