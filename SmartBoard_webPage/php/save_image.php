<?php
ini_set('error_reporting', E_ALL);
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);

$targetdir = '/home/pi/';   
$targetfile = $targetdir.$_FILES['canvasImage']['name'];


$uploads_dir = '/var/www/html/SmartBoard/php';
$tmp_name = $_FILES['canvasImage']['tmp_name'];
$name = $_FILES['canvasImage']['tmp_name'];
echo "--"+ $tmp_name + "\n";
echo "++"+$name +"\n";

if (is_uploaded_file($tmp_name)) {
   echo "File ". $tmp_name." uploaded successfully.\n";
} else {
   echo "Possible file upload attack: ";
   echo "filename '". $tmp_name . "'.";
}

copy($_FILES['canvasImage']['tmp_name'],"uploads/".basename($_FILES['canvasImage']['name']));
// move_uploaded_file($tmp_name, "/home/pi/qqq.png");

// if(move_uploaded_file($_FILES['canvasImage']['tmp_name'], $targetdir.'img.jpg'))
// 	echo "file uploaded succeeded";
// else 
// 	echo "file upload failed";

 


?>