<?php include("conexion.php")?>
<!DOCTYPE html>
<html lang="en">
<head>
<link rel="stylesheet" type="text/css" href="esstilo.css"> 
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width">
    <title>Pagina Principal</title>
    
</head>

   <nav class = "navbar navbar-dark bg-dark" id="naveg">
     <div class = "container">
         <a href= "Main.php" class="navbar-brand"> INICIO </a>
         <a href= "AgregarCliente.php" class="navbar-brand"> AGREGAR CLIENTE </a>
         <a href= "EC.php" class="navbar-brand"> ELIMINAR CLIENTE </a>
         <a href= "ConsultarCliente.php" class="navbar-brand"> CONSULTAR CLIENTE</a>
         <a href= "Ayuda.php" class="navbar-brand"> AYUDA </a>
         <form method="POST">
<input id="btnclose" type="submit" value="Cerrar sesión" name="btncerrar" class="btn btn-info" />
</form>
         
     </div>
    </nav>
<?php



if(isset($_POST['btncerrar']))
{
	session_destroy();
	header('location: Cierre_sesiopn.php');
}

?>

<body>
  <br>
<h1 id="Mensaje">Bienvenido Asesor</h1>
</body>
<body id="Estato2" >
<div id = "MovisGif">
<img src="movistarevo.gif" width="460cm" height="280">
</div>
</body>
</html>