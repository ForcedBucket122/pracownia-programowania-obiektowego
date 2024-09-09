nrTygodnia=input("Podaj dzień tygodnia")
match nrTygodnia:
    case"1":
        print("poniedziałek")
    case"2":
        print("wtorek")
    case"3":
        print("sroda")
    case"4":
        print("czwartek")
    case"5":
        print("piontek")
    case"6":
        print("sobota")
    case"7":
        print("NIEdziela")
    case other:
        print("Nie")