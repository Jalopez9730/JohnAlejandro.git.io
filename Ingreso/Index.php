<?php include("conexion.php")?>

<!DOCTYPE html>
<html>
    <head> 
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css"> 
     <meta charset="utf-8">
     <meta name="viewport" content="width=device-width height=device-height">
     <div>
     <img src="Movistar-Logo.jpg" class="pic2" alt="Movistar " height="150px" width="300px">
    </div>
     <title img src="Movis.jpeg" height="5mm" width="5mm">Movistar</title>
     
    </head>
    <body>
<center>
 <h1 class="user">Ingreso usuario</h1>    
 <div id ="container" width="30cm" height="10cm">
<h2>¡Bienvenido!</h2>
 <div class="card card-body">
           <form action="logeo_seq.php" method ="POST">
              <label for="ingrese usuario">Usuario:</label><br>
              <input type="text" name="User" class="cuadros" placeholder="&#129333;Ingrese usuario " required autofocus><br>
             <br>
              <label for="Ingrese contraseña">Digite  su contraseña:</label><br>
              <input type="password" name="Password" class="cuadros" placeholder="&#128272;Ingrese Clave" required>
              <br>
              <br>
             <p><button type="Submit" id="btnc" value="INGRESAR" class="btn btn-info" name ="Save"> INGRESAR </button><br></p>    
         </form>
    </div>
</div>
</center>
    </body>
    <br>
    <br>
    <br>
    <footer>Powered by SQL</footer>
</html>

