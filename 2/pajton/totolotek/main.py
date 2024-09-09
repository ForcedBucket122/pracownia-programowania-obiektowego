import random

losowane = []
wylosowane = []
typowane=[]
trafione = []
for i in range(49):
    losowane.append(i+1)
def losuj(losowane, wylosowane):
    while(len(wylosowane)< 6):
        index = random.randint(0, len(losowane)-1)
        if not(losowane[index] in wylosowane):
                wylosowane.append(losowane[index])
def typuj(typowane):
    j=1
    while(len(typowane)< 6):

        i = int(input(f"podaj liczbe {j}. od 0 do 49 " ))
        if i > 0 and i < 50:
            if not i in typowane:
                typowane.append(i)
                j+=1
def traf(trafione):
    wygrane = 0
    for i in typowane:
        if i in wylosowane:
            trafione.append(i)
            wygrane+=1
    return wygrane
losuj(losowane, wylosowane)
typuj(typowane)
traf(trafione)
print("Liczby losowane",wylosowane)
print("Liczby typowane",typowane)
print(f"Trafiłeś ",traf(trafione), " razy")
print("Liczby trafione",trafione)