# napisz program totolotek (losowanie 6 liczb z 49) <1,49>. liczby typowanie podaje użytkownik. program wyświetla liczby
# a) wylosowane
# b) wytypowane
# c) trafione
# wszystkie te dane zapisuj do pliku
# program działą w pętli aż użytkownik zdecyduje o wyjściu

import random
import datetime

x=datetime.datetime.now()
print(x)
losowane = []
typowane = []
trafione = []

wyniki = open("totolotek.txt", "a", encoding="utf-8")


def typowaned():

    liczba1 = int(input("Podaj pierwsza liczbe (od 1 do 49):"))
    while liczba1 < 1 or liczba1 > 49 or str(liczba1) in typowane:
        liczba1 = int(input("Taka liczba nie miesci sie w podanym zakresie. Podaj inna liczbe:5 "))
    typowane.append(str(liczba1))

    liczba2 = int(input("Podaj druga liczbe (od 1 do 49):"))
    while liczba2 < 1 or liczba2 > 49 or str(liczba2) in typowane:
        liczba2 = int(input("Taka liczba nie miesci sie w podanym zakresie. Podaj inna liczbe: "))
    typowane.append(str(liczba2))

    liczba3 = int(input("Podaj trzecia liczbe (od 1 do 49):"))
    while liczba3 < 1 or liczba3 > 49 or str(liczba3) in typowane:
        liczba3 = int(input("Taka liczba nie miesci sie w podanym zakresie. Podaj inna liczbe: "))
    typowane.append(str(liczba3))

    liczba4 = int(input("Podaj czwarta liczbe (od 1 do 49):"))
    while liczba4 < 1 or liczba4 > 49 or str(liczba4) in typowane:
        liczba4 = int(input("Taka liczba nie miesci sie w podanym zakresie. Podaj inna liczbe: "))
    typowane.append(str(liczba4))

    liczba5 = int(input("Podaj piata liczbe (od 1 do 49):"))
    while liczba5 < 1 or liczba5 > 49 or str(liczba5) in typowane:
        liczba5 = int(input("Taka liczba nie miesci sie w podanym zakresie. Podaj inna liczbe: "))
    typowane.append(str(liczba5))

    liczba6 = int(input("Podaj szosta liczbe (od 1 do 49):"))
    while liczba6 < 1 or liczba6 > 49 or str(liczba6) in typowane:
        liczba6 = int(input("Taka liczba nie miesci sie w podanym zakresie. Podaj inna liczbe: "))
    typowane.append(str(liczba6))


def wylosowane():
    while len(losowane) < 6:
        los = random.randrange(1, 49)
        if not los in losowane:
            losowane.append(str(los))


def sprawdzanie():
    for el in typowane:
        if el in losowane:
            trafione.append(str(el))


typowaned()
wylosowane()
sprawdzanie()

wyniki.write("\n-------------------------------------\n")
wyniki.write(x.strftime("%c"))
wyniki.write("\n")
wyniki.write("\ntypowane:\n")
wyniki.write(str(typowane))
wyniki.write("\nlosowane:\n")
wyniki.write(str(losowane))
wyniki.write("\ntrafione:\n")
wyniki.write(str(trafione))

wyniki.close()