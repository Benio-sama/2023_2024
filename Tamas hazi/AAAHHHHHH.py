szerzo= ["J. K. Rowling", "Andrzej Sapkowski", "M. J. Arlidge"]
cim= ["Harry Potter és a bölcsek köve", "Tündevér", "Ecc, pecc"]
def f1():
    for i in range(len(szerzo)):
        print(f"{szerzo[i]} - {cim[i]}", end=", ")
    print()
 
def f2():
    kereses=input("Kerek egy szerzot vagy cimet:")
    talalat=0
    for i in range(len(szerzo)):
        if kereses==szerzo[i]:
            talalat+=1
            print(f"{szerzo[i]} - {cim[i]}")
        if kereses==cim[i]:
            talalat+=1
            print(f"{szerzo[i]} - {cim[i]}")
    if talalat==0:
        print("Nincs ilyen konyvunk.")
    print()
 
def f3():
    ujszerzo=input("Kerem a konyv szerzojet: ")
    ujcim=input("Kerem a konyv cimet:")
    egyezes=0
    for item in cim:
        if ujcim==item:
            egyezes+=1
            print("Ilyen konyvunk mar van.")
    if egyezes==0:
        szerzo.append(ujszerzo)
        cim.append(ujcim)
        print(f"{ujszerzo} - {ujcim} hozzaadasra kerult a konyvtarhoz.")
    print()
'''
szerzo= ["J. K. Rowling", "Andrzej Sapkowski", "M. J. Arlidge"]
cim= ["Harry Potter és a bölcsek köve", "Tündevér", "Ecc, pecc"]
'''
def f4():
    KKszerzoVcim=input("Kerem a kolcsonozni kivant konyv szerzojet vagy cimet: ")
    KKkonyvkeszleten=0
    for i in range(0,len(szerzo)):
        if KKszerzoVcim==szerzo[i]:
            KKkonyvkeszleten+=1
            print("Tessek a konyved.")
        if KKszerzoVcim==cim[i]:
            KKkonyvkeszleten+=1
            print("Tessek a konyved.")
        if KKkonyvkeszleten==1:
                szerzo.pop(i)
                cim.pop(i)
                #print(*szerzo)
                #print(*cim)
                break
    if KKkonyvkeszleten==0:
        print("Nincs ilyen konyvunk keszleten.")
    print()
def f5():
    VHszerzo=input("Kerem a konyv szerzojet: ")
    VHcim=input("Kerem a konyv cimet: ")
    VanIlyenCim=0
    for item in cim:
        if item==VHcim:
            VanIlyenCim+=1
            print("Van ilyen cimunk tartsd meg.")
    if VanIlyenCim==0:
        cim.append(VHcim)
        szerzo.append(VHszerzo)
        print("A konyv visszavetele sikeres volt.")
    print()
def f6():
    exit
 
'''def main():
        while True:
            print("1. Könyvek listázása.\n2. Könyv keresése szerző vagy cím alapján.\n3. Új könyv hozzáadása.\n4. Könyv kölcsönzése\n5. Könyv visszavétele\n6. Kilepes")
            v=int(input("Melyik opciot valasztod:"))
            match v:
                case 1: f1()
                case 2: f2()
                case 3: f3()
                case 4: f4()
                case 5: f5()
                case 6: break
main()
'''
def main():
    f4()
main()