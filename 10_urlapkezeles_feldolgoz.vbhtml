<!DOCTYPE html>
@Code
    Dim veznev = Request("veznev")
    Dim kernev = Request("kernev")
    Dim eletkor = Request("eletkor")
    Dim nev = veznev & " " & kernev
End Code

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>Űrlap feldolgozás</title>
    </head>
    <body>
        <h1>Regisztrációs adatok</h1>
        <p>Név: @nev</p>
        <p>Életkor: @eletkor</p>
    </body>
</html>
