<!DOCTYPE html>
@Code
    if IsPost then
        Dim veznev = Request("veznev")
        Dim kernev = Request("kernev")
        Dim eletkor = Request("eletkor")
        Dim nev = veznev & " " & kernev
        
        @<text>
            <h1>Regisztrációs adatok</h1>
            <p>Név: @nev</p>
            <p>Életkor: @eletkor</p>
        </text>
    end if
End Code

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
        @Code
            if not IsPost then
                @<text>
                    <form method="post" action="10_urlapkezeles_feldolgoz.vbhtml">
                        <fieldset>
                            <legend>Személyes adatok</legend>
                            <label for="veznev">Vezetéknév:</label> <input type="text" name="veznev"/><br/>
                            <label for="kernev">Keresztnév:</label> <input type="text" name="kernev"/><br/>
                            <label for="eletkor">Életkor:</label> <input type="text" name="eletkor"/>
                        </fieldset>
                        
                        <input type="submit" value="Mehet"/>
                        <input type="reset" value="Törlés"/>
                    </form>
                </text>
            end if
        End Code
    </body>
</html>
