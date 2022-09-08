<?php
include("conexion.php");

if(isset($_GET['id'])){
    $id = $_GET['id'];
    $query = "SELECT * FROM clientes WHERE Cedula = $id";
    $result  = mysqli_query($conn, $query );

    if (mysqli_num_rows($result) == 1){
        $row = mysqli_fetch_array($result);
        $Ciudad = $row['Ciudad'];
        $Departamento = $row['Departamento'];
        $Descripcion = $row['Descripcion'];
        $Direccion = $row['Direccion'];
        $Nombre = $row['Nombre'];
        $fecha = $row['Fecha'];
        $Servicio = $row['TipoS'];
        
    }
}

if(isset($_POST['actualizar'])){

    $id = $_GET['id'];
    $Ciudad = $_POST['Ciudad'];
    $Departamento = $_POST['Departamento'];
    $Descripcion = $_POST['Descripcion'];
    $Direccion = $_POST['Direccion'];
    $Nombre = $_POST['Nombre'];
    $fecha = $_POST['Fecha'];
    $Servicio = $_POST['service'];

    $query  = "UPDATE  clientes set Ciudad = '$Ciudad', Departamento = '$Departamento', Descripcion = '$Descripcion', Direccion ='$Direccion', Nombre = '$Nombre', Fecha = '$fecha', TipoS = '$Servicio' WHERE  Cedula = $id";
    mysqli_query($conn, $query);

    echo "<script>alert('Usuario modificado con exito');window.location= 'Vista_Mod_User.php' </script>";
   
}

?>

<?php include("header.php") ?>

<nav class = "navbar navbar-dark bg-dark" id="naveg">
     <div class = "container">

         <a href= "Main.php" class ="navbar-brand"> INICIO </a>
         <a class ="navbar-brand" > MODIFICACION </a>
         <a href= "Vista_Mod_User.php" class ="navbar-brand"> < VOLVER </a>
     </div>
<body id="Fondoag" width="250px">
</nav>
<center>
<br>
<br>
<div id="forma2">
    <br>
    <div >
        <div>
            <div >
                <form action="Consul_Cliente.php?id=<?php echo $_GET['id'];?>" method="POST">
                <label >Actualiza Ciudad</label><br>
                    <div class="form-group">
                        <input type="text" id="normaton" name="Ciudad" value="<?php echo $Ciudad; ?>" class="form-control" placeholder="Actualiza Ciudad" autofocus>
                     </div>
                     <br>
                     <label >Actualiza Departamento</label><br>
                     <div class="form-group">
                        <input type="text" id="normaton" name="Departamento" value="<?php echo $Departamento; ?>" class="form-control" placeholder="Actualiza Departamento">
                     </div>
                     <br>
                     <label >Actualiza Descripcion</label><br>
                     <div class="form-group">
                        <textarea type="text" id="normaton" name="Descripcion" value="<?php echo $Descripcion; ?>" class="form-control" placeholder="Actualiza Descripcion"></textarea>
                     </div>
                     <br>
                     <label >Actualiza Direccion</label><br>
                     <div class="form-group">
                        <input type="text" id="normaton" name="Direccion" value="<?php echo $Direccion; ?>" class="form-control" placeholder="Actualiza Direccion">
                     </div>
                     <br>
                     <label >Actualiza Nombre</label><br>
                     <div class="form-group">
                        <input type="text" id="normaton"name="Nombre" value="<?php echo $Nombre; ?>" class="form-control" placeholder="Actualiza Nombre">
                     </div>
                     <br>
                     <label >Actualiza Fecha</label><br>
                     <div class="form-group">
                        <input type="date" id="normaton"name="Fecha" value="<?php echo $fecha; ?>" class="form-control" placeholder="Actualiza Nombre">
                     </div>
                     <br>
                     <label >Actualiza el tipo de servicio</label><br>
                     <select name="service" id="normaton">
                       <option value="Option" disabled>-Seleccione una opcion-</option>
                       <option value="Hogar">Hogar</option>
                       <option value="Movil">Movil</option></select><br>
                     <br>
                     <button type="submit" class="btn btn-primary" id="btnclose" name="actualizar">Actualizar</button>
                </form>
            </div>
        </div>
    </div>
    <br>
</div>
</center>
</body>
