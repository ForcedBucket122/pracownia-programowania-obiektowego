import time
def odczytCalegoPliku(sciezka):
    print('=======================================ODCZYT CALEGO PLIKU=======================================')
    droga='./'+sciezka+'.txt'
    plik=open(droga,'r',encoding='utf-8')
    calyTekst=plik.read()
    print(calyTekst)
    print('=============================================================================================')

    plik.close()
def odczytFragmentuPliku(sciezka,ileZnakow):
    print('=======================================ODCZYT FRAGMENTU PLIKU=======================================')
    droga = './' + sciezka + '.txt'
    plik = open(droga, 'r', encoding='utf-8')
    calyTekst = plik.read(ileZnakow)
    print(calyTekst)
    print('=============================================================================================')

    plik.close()

def odczytPoJednymZnakuPliku(sciezka):
    print('=======================================ODCZYT PO JEDNYM ZNAKU PLIKU=======================================')
    droga = './' + sciezka + '.txt'
    pliko = open(droga, 'r', encoding='utf-8')
    znak = pliko.read(1)
    while znak:
        print(znak,end="")
        time.sleep(0.01)
        znak=pliko.read(1)
    print('\n=============================================================================================')

    pliko.close()

# sciezka=input("Podaj nazwę pliku: ")
# ileZnakow=int(input("Podaj ilosc znakow: "))
ileZnakow=20
sciezka='odczyt'
odczytCalegoPliku(sciezka)
odczytFragmentuPliku(sciezka,ileZnakow)
odczytPoJednymZnakuPliku(sciezka)



