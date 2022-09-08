<?php  include("conexion.php")?>
<!DOCTYPE html>
<html lang="en">
<head>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="esstilo.css"> 
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Agregar</title>
</head>
<nav class = "navbar navbar-dark bg-dark" id="naveg">
     <div class = "container">
         <a href= "Main.php" class ="navbar-brand"> < VOLVER </a>
         <a class ="navbar-brand"> AGREGAR USUARIO </a>
         <a class ="navbar-brand">  </a>
     </div>
    </nav>
    <br>
    <br>
<body id="Fondoag">
<div id="forma" img src="giff.gif">
           <form action="Insert_User.php" method ="POST">
              <label>Nombre:</label><br>
              <input type="text" name="name" id="normaton" class="col-sm-2 col-form-label" placeholder="Ingrese nombres y apellidos" required autofocus><br>
             <br>
             <label >Cedula:</label><br>
              <input type="text" name="id" id="normaton" class="col-sm-2 col-form-label" placeholder="Ingrese numero de Identificacion" required><br>
             <br>
             <label >Direccion</label><br>
              <input type="text" name="adress" id="normaton" class="col-sm-2 col-form-label" placeholder="Ingrese la direccion" required><br>
             <br>
             <label >Tipo de Servicio</label><br>
             <select name="service" id="normaton" required>
                 <option value="Option">-Seleccione una opcion-</option>
                 <option value="Hogar">Hogar</option>
                 <option value="Movil">Movil</option></select><br>
             <br>
              <label >Descripcion</label><br>
              <textarea type="text" name="description" id="normaton" class="col-sm-2 col-form-label" placeholder="Descripcion" required></textarea><br>
             <br>
             <label >Fecha</label><br>
              <input type="date" name="date" id="normaton" class="col-sm-2 col-form-label" required></input><br>
             <br>
             <label >Ciudad</label><br>
              <input type="text" name="city" id="normaton" class="col-sm-2 col-form-label" placeholder="Ingrese la ciudad" required><br>
             <br>
              <label >Departamento</label><br>
              <input type="text" name="department" id="normaton" class="col-sm-2 col-form-label" placeholder="Departamento"required>
              <br>
              <br>
             <p><button type="Submit" value="Guardar" class="btn btn-primary" id="btnclose" name ="Save"> Registrar </button><br></p>    
         </form>
</div>
<div id="Imagenp">
    <img src="Telefono.gif">
</div>

<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>

  
</body>



</html>