Borde.addEvenListener('#Borde', procesarClick, false);

function procesarClick(){

    document.getElementsByClassName("Borde").addEvenListener("click",click1,false);

}

function click1()
{
    window.alert("Ingrese de nuevo");
}