try:
    dzialanie = float(input("""Opcje: 
    1. Dodawanie
    2. Odejmowanie
    3. Mnożenie
    4. Dzielenie
    5. Wyjście z programu
    Wybierz Opcje: """))
    match dzialanie:
        case 1:
            l1=float(input("Podaj liczbe 1: "))
            l2=float(input("Podaj liczbe 2: "))
            print(l1+l2)
        case 2:
            l1=float(input("Podaj liczbe 1: "))
            l2=float(input("Podaj liczbe 2: "))
            print(l1-l2)
        case 3:
            l1=float(input("Podaj liczbe 1: "))
            l2=float(input("Podaj liczbe 2: "))
            print(l1*l2)
        case 4:
            l1=float(input("Podaj licznik: "))
            l2=float(input("Podaj mianownik: "))
            print(l1/l2)
        case 5:
            print("Wyjście z programu")
            exit()
        case other:
            print("Błąd: Nie ma takiej opcji")

except ValueError:
    print("Niewłaściwy typ danych")
except ZeroDivisionError:
    print("Wystąpił błąd dzielenia przez zero")
except Exception as e:
    print("Wystąpił błąd", e)