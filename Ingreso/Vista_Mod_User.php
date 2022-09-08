<?php include("conexion.php");?>
<!DOCTYPE html>
<html lang="en">
<head>
<link rel="stylesheet" type="text/css" href="esstilo.css">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Modificar</title>
</head>
<body id="Estato" >   
<nav class = "navbar navbar-dark bg-dark" id="naveg">
     <div class = "container">
         <a href= "Main.php" class ="navbar-brand" > INICIO </a>
         <a class ="navbar-brand" > VISTA DE CONSULTA</a>
         <a href= "ConsultarCliente.php" class ="navbar-brand" > < VOLVER</a>
     </div>
    </nav>
    <br>
    <br>
<div id="Tabla1">
<div class="Table">
<div class="col-md-8">
<table class ="table table-bordered">
      <thead>
           <tr>
           <th>Identificacion</th>
             <th>Ciudad</th>
             <th>Departamento</th>
             <th>Direccion</th>
             <th>Descripcion</th>
             <th>Nombre</th>
             <th>Tipo de Servicio</th>
             <th>Fecha</th>
             <th>Modificar</th>
           </tr>
      </thead>
      <tbody>
         <?php 
           $query ="SELECT * FROM clientes ";
           $result = mysqli_query($conn, $query);
          
           while ($row = mysqli_fetch_array($result)){ ?>
              <tr>
              <td><?php echo $row['Cedula']?></td>
              <td><?php echo $row['Ciudad']?></td>
              <td><?php echo $row['Departamento']?></td>
              <td><?php echo $row['Direccion']?></td>
              <td><?php echo $row['Descripcion']?></td>
                <td><?php echo $row['Nombre']?></td>
                <td><?php echo $row['TipoS']?></td>
                <td><?php echo $row['Fecha']?></td>
                <td>
                   <a href="Consul_Cliente.php?id=<?php echo $row['Cedula']?>" class ="btn btn-primary" id="btnclose">
                   <i class="bi bi-pencil-square"></i>
                   </a>
                </td>
           </tr>

          <?php } ?>
      
      </tbody>
</table>
</div>
</div>
</div>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
</html>