class Szoba:
    def __init__(self, sorszam, foglalt, hanyan):
        self.sorszam = sorszam
        self.foglalt = foglalt
        self.hanyan = hanyan
    def __str__(self):
        return f"A {self.sorszam}. szoba, foglalasi statusza: {self.foglalt}, {self.hanyan} ember altal."
    
szoba1 = Szoba(1, False, 0)
szoba2 = Szoba(2, False, 0)
szoba3 = Szoba(3, False, 0)
szoba4 = Szoba(4, False, 0)
szoba5 = Szoba(5, False, 0)
szoba6 = Szoba(6, False, 0)
szoba7 = Szoba(7, False, 0)
szoba8 = Szoba(8, False, 0)
szoba9 = Szoba(9, False, 0)
szoba10 = Szoba(10, False, 0)
szoba11 = Szoba(11, False, 0)
szoba12 = Szoba(12, False, 0)

panzio = [szoba1, szoba2, szoba3, szoba4, szoba5, szoba6, szoba7, szoba8, szoba9, szoba10, szoba11, szoba12]
nemszabad = 0

def Foglalas():
    global nemszabad
    erkezok = int(input("hanyan erkeznek: "))
    if erkezok > 24:
        print("max 24 embert tudunk elszallasolni.")
    elif nemszabad >= erkezok:
        print("nincs ennyi szabad szoba")
    else:
        for item in panzio:
            if erkezok == 1:
                item.foglalt = True
                item.hanyan = 1
                erkezok -= 1
                nemszabad += 1
                #print(item.sorszam)
                #print(erkezok)
            while erkezok != 1 and erkezok != 0 and erkezok > 0 and item.foglalt != True:
                item.foglalt = True
                item.hanyan = 2
                erkezok -= 2
                nemszabad += 1
                #print(item.sorszam)
                #print(erkezok)
        print("mindenki el lett szallasolva")

def FoglalasListazas():
    for item in panzio:
        if item.foglalt:
            print(f"Szoba szama: {item.sorszam}, {item.hanyan} - en vannak.")

def FoglalasTorles():
    szobaszam = int(input("kerem a torolni kivant szoba szamat: "))
    if szobaszam > 24:
        print("csak 24-ig vannak szamozva a szobak")
    else:
        for item in panzio:
            if item.sorszam == szobaszam:
                item.foglalt = False
                item.hanyan = 0

def VendegekSzama():
    ossz = 0
    for item in panzio:
        ossz += item.hanyan
    print("Vendegek szama: ", ossz)

def Bevetel():
    bevetel = 0
    for item in panzio:
        if item.foglalt:
            if item.hanyan == 1:
                bevetel += 24000
            else:
                bevetel += 36000
    return bevetel

def Kulonbseg():
    telthaz = len(panzio) * 36000
    esett = telthaz - Bevetel()
    print(f"a fogados {esett} Ft-tal maradt el a telthazas keresettol ({telthaz} Ft)")

def Kilepes():
    exit

def Main():
    Foglalas()
    FoglalasListazas()
    FoglalasTorles()
    FoglalasListazas()
    VendegekSzama()
    print(f"a panzio bevetele: {Bevetel()} Ft")
    Kulonbseg()
    Kilepes()
Main()