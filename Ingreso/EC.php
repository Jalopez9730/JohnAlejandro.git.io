<?php include("conexion.php");?>
<!DOCTYPE html>
<html lang="en">
<head>  
<link rel="stylesheet" type="text/css" href="esstilo.css"> 
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://www.google.com/recaptcha/api.js" async defer></script>
    <title>Eliminar</title>
</head>
<nav class = "navbar navbar-dark bg-dark" id="naveg">
     <div class = "container">
         <a href= "Main.php" class ="navbar-brand"> < VOLVER </a>
         <a class ="navbar-brand">ELIMINAR USUARIO </a>
         <a class ="navbar-brand">  </a>
     </div>
    </nav>

<body id="Estato" >
    <center>
        <br>
        <br>
        <br>
        <div id="Corma">
    <div class="form" >
           <form action="Delete_User.php" method ="POST">
              <label >Documento de Identificacion</label>
              <br>
              <br>
              <input type="text" id="normaton" name="Identificacion" class="col-sm-2 col-form-label" placeholder="Ingrese documento" autofocus required><br>
              
              <br>
             <p><button type="Submit" value="Guardar" class="btn btn-primary" id="btnclose" name ="Elim"> Eliminar </button><br></p>    
         </form>
    </div>
</div>
</center>
</body>
</html>