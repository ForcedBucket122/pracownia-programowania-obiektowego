import random


def wyswietlNieszyfrowany():
    pliknsz = open("wiersz.txt", "r", encoding="UTF-8")

    print(pliknsz.read())

    pliknsz.close()

def wyswietlSzyfrowany():
    pliksz = open("zaszyfrowany.txt", "r", encoding="UTF-8")

    print(pliksz.read())

    pliksz.close()

def wyswietlOdszyfrowany():
    plikosz = open("odszyfrowany.txt", "r", encoding="UTF-8")

    print(plikosz.read())

    plikosz.close()

# def szyfruj():
#     pliknsz = open("wiersz.txt", "r", encoding="UTF-8")
#     tekstnsz = pliknsz.read()
#     tekstsz = ""
#
#     klucz = int(input("Podaj klucz: "))
#
#     for i in tekstnsz:
#         tekstsz += chr(ord(i) + klucz)
#
#
#     pliknsz.close()
#
#     pliksz = open("zaszyfrowany.txt", "w", encoding="UTF-8")
#
#     pliksz.write(tekstsz)


# def odszyfruj():
#     pliksz = open("zaszyfrowany.txt", "r", encoding="UTF-8")
#     tekstsz = pliksz.read()
#     tekstosz = ""
#
#     klucz = int(input("Podaj klucz: "))
#
#     for i in tekstsz:
#         tekstosz += chr(ord(i) - klucz)
#
#     pliksz.close()
#
#     plikosz = open("odszyfrowany.txt", "w", encoding="UTF-8")
#
#     plikosz.write(tekstosz)



def szyfruj():
    pliknsz = open("wiersz.txt", "r", encoding="UTF-8")
    tekstnsz = pliknsz.read()
    tekstsz = ""
    tekstkod = ""

    for i in tekstnsz:
        k = random.randrange(0, 50)
        tekstsz += chr((ord(i) + k))
        tekstkod += chr(k)


    pliknsz.close()

    pliksz = open("zaszyfrowany.txt", "w", encoding="UTF-8")
    plikkod = open("kod.txt", "w", encoding="UTF-8")

    pliksz.write(tekstsz)
    plikkod.write(tekstkod)

    pliksz.close()
    plikkod.close()

def odszyfruj():
    pliksz = open("zaszyfrowany.txt", "r", encoding="UTF-8")
    plikkod = open("kod.txt", "r", encoding="UTF-8")
    tekstsz = pliksz.read()
    tekstkod = plikkod.read()
    tekstosz = ""
    j = 0
    for i in tekstsz:
        k = ord(tekstkod[j])
        tekstosz += chr((ord(i) - k))
        j += 1

    pliksz.close()
    plikkod.close()

    plikosz = open("odszyfrowany.txt", "w", encoding="UTF-8")

    plikosz.write(tekstosz)

    plikosz.close()


while True:
    print("""Wybierz opcje:
    1. wyswietl niezaszyfrowany plik
    2. zaszyfruj plik
    3. wyswietl plik zaszyfrowany
    4. odszyfruj plik
    5. wyswietl odszyfrowany plik
    0. wyjscie""")

    opcja = int(input())

    match opcja:
        case 1:
            wyswietlNieszyfrowany()
        case 2:
            szyfruj()
        case 3:
            wyswietlSzyfrowany()
        case 4:
            odszyfruj()
        case 5:
            wyswietlOdszyfrowany()
        case 0:
            exit(0)
        case _:
            print("Nie ma takiej opcji!")