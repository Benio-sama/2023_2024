alkalmazas telepitese:
    npm init
    npm i express mysql2

http://localhost:3000
thunder client
xampp-ban apache es mysql start es mysql admin megnyit
adatbazis importalasa

vegpontok:
    GET: /ajandekok
        visszaadja az osszes ajandekot az adatbazisban json formatumban, 200-as status koddal, 
        ha nem megy akkor 500-as status kod,
        minden esetben json formatumban kuldi az errort is,
        pl: GET: http://localhost:3000/ajandekok
            Response: 200 OK
                [
                    {
                        "id": 1,
                        "nev": "Kisauto",
                        "ar": 2000
                    },
                    //es a tobbi
                ]
    GET: /ajandekok/:id 
        visszaadja a megadott idvel rendelkezo ajandekot,
        302-es status kod ha mukodik es elkuldi az ajandekot json formatumban,
        503-as status ha nem mukodik a funkcio,
        404-es status ha az adott idvel nincs rendelkezo ajandek,
        minden errort jsonben kuld,
        ha az id nem szam akkor 400-as status kod es error jsonben kuldve,
        pl: GET: http://localhost:3000/ajandekok4
            Response: 302 Found
                [
                    {
                        "id": 4,
                        "nev": "Fa vasut",
                        "ar": 2500
                    }
                ]
    POST: /ajandekok
        json formatumban kell megadni az adatokat, nevet es arat,
        a nevnek minimum 1 karakter hosszunak kell lennie, az arnak nagyobbnak mint 0,
        ha a validacio nem teljesul, akkor 400-as status, error jsonbe kuldve,
        ha teljesul a validacio akkor 201-es status es megjeleniti az uj jsont a tobbivel
        ha nem mukodik az adatbazis akkor 503-as status, error json formatumban jelenik meg,
        pl: POST: http://localhost:3000/ajandekok
                Body: 
                    JSON:
                    {
                        "nev": "billentyuzet",
                        "ar': 10000
                    }
            Response: 201 Created
                {
                    "nev": "billentyuzet",
                    "ar': 10000,
                    "id": a kovetkezo id
                }
    PUT: /ajandekok/:id
        linkbe kell irni az id-t es jsonben varja az adatokat, 
        pl: PUT: http://localhost:3000/ajandekok/10
                Body: 
                    JSON:
                    {
                        "nev": "asd",
                        "ar": 200
                    }
            Response: 200 OK
        szinten validalas tortenik, nev legyen legalabb 1 karakter, ar legyen nagyobb mint 0,
        ha nem valosul meg a validacio, 400-as status, error jsonben kuldve,
        ha megvalosul akkor 200-as status,
        ha nem mukodik az adatbazis akkor 503-as status, error jsonben kuldve,
        ha az id nem szam akkor 400-as status kod es error jsonben kuldve
    DELETE: /ajandekok/:id
        linkbe kell irni az id-t es torli azzal az id-vel rendelkezo adatot
        ha sikeres a torles akkor 200-as status
        ha nem akkor 503-as status, error jsonben kuldve,
        ha az id nem szam akkor 400-as status kod es error jsonben kuldve,
        pl: DELETE: http://localhost:3000/ajandekok/11
            Response: 200 OK

