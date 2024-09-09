class NieWlasiciwyiek(Exception):
    def __init__(self):
        print("kys")

try:

    a=float(input("wiek: "))

    if a<0:
        raise NieWlasiciwyiek
    b=float(input("Podaj b:"));

except ValueError:
    print("niewlasciwy typ danych")
except ind as e:
    print("Nie dziel przez zero")
except Exception as e:
    print("Error")

print("Program dziala dalej")
