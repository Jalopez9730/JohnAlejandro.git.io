<?php include("conexion.php")?>
<!DOCTYPE html>
<html lang="en">
<head>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="esstilo.css"> 
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cierre Sesion</title>
</head>
<body>
    <div id="container">
    <center>
<form method="POST">
    <br>
    
    <br>
    <br>
    <br>
    <br>
    <br>
    <br> Su Sesion ha finalizado!
    <br>
    <br>
   <p><button id="btnc" class="btn btn-info" type="submit" name="btnCierre"> Volver a inicio </button></p>
</br>
</br>
<img  class="imageny "src="webm.png" width="900cm" height="180cm">
</br>
</br>
</br>


</form>
    </center>
</div>
</body>
</html>

<?php 

if(isset($_POST['btnCierre']))
{
	session_destroy();
	header('location: Index.php');
}

?>
