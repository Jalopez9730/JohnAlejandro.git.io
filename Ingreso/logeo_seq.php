<?php

include ("conexion.php");

	$nombre=$_POST['User'];
	$pass=$_POST['Password'];
	
	$query=mysqli_query($conn,"SELECT * FROM Asesores where Usuario = '".$nombre."' AND Contraseña = '".$pass."'");
	$nr=mysqli_num_rows($query);
	
	if($nr == 1)
	{
        header("location: Main.php");
	}
	else if ($nr == 0)
	{
		echo "<script>alert('Usuario y/o contraseña incorrectos');window.location= 'Index.php' </script>";
	}
	
	
?>

