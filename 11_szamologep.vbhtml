<!DOCTYPE html>
@Code
    Dim eredmeny as single
    Dim eredmeny_sz = ""
    Dim muvelet = " "
    Dim va = ""
    Dim vb = ""
    
    'Ha Post kérés van
    if IsPost then
        'Az átküldött adatok kiolvasása
        va = Request("a")
        vb = Request("b")
        muvelet = Request("muvelet")
        
        'A műveletek elvégzése
        if muvelet = "+" then
           eredmeny = va.AsDecimal() + vb.AsDecimal()
        end if
        if muvelet = "-" then
            eredmeny = va.AsDecimal() - vb.AsDecimal()
        end if
        eredmeny_sz = eredmeny.ToString()
    end if
End Code
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>Összeadó</title>
    </head>
    <body>
        <form method="post">
            <input type="text" name="a" size="5" value="@va"/> @muvelet <input type="text" name="b" size="5" value="@vb"/> = @eredmeny_sz <br/>
            <input type="submit" value="+" name="muvelet"/>
            <input type="submit" value="-" name="muvelet" />
        </form>
    </body>
</html>
