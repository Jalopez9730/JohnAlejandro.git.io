<?php 


include ('conexion.php');

if(isset($_POST['Save'])){
    
    
    $nombre = $_POST['name'];
    $cedula = $_POST['id'];
    $direccion = $_POST['adress'];
    $descripcion = $_POST['description'];
    $ciudad = $_POST['city'];
    $departamento = $_POST['department'];
    $fecha = $_POST['date'];
    $TipoS = $_POST['service'];

    $query ="INSERT INTO clientes(Nombre, Cedula, Direccion, TipoS, Ciudad, Departamento, Descripcion, Fecha) VALUES ('$nombre', '$cedula', '$direccion', '$TipoS', '$ciudad', '$departamento', '$descripcion', '$fecha')";
    $result = mysqli_query($conn, $query);

    if(!$result){
        die("query failed");
    }


    echo "<script>alert('Usuario creado con exito');window.location= 'AgregarCliente.php' </script>";
   
}
   
?>