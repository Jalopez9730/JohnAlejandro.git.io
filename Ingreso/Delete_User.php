<?php 

include ('conexion.php');

if(isset($_POST['Elim'])){
    
    $Identificacion = $_POST['Identificacion'];

    $query ="DELETE FROM clientes WHERE Cedula = $Identificacion";
    $result = mysqli_query($conn, $query);


    if(!$result){

        echo "<script>alert('El usuario no existe');window.location= 'EliminarCliente.php' </script>";
    }

    echo "<script>alert('Usuario Eliminado con exito');window.location= 'EC.php' </script>";
   
}
   
?>