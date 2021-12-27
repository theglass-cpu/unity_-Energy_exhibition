<?php 
 require_once "DBconnection_E.php";

 $con = mysqli_connect($host,$db_user,$db_password,$db_name);

 mysqli_query($con,'SET NAMES utf8');

$query = $_POST["query"];


if(mysqli_connect_error($con))//연결오류시 
{
    echo "Failed to connect to MySQL: " . mysqli_connect_error();

}


//유저ID번호 얻기

$sql_select = "SELECT * FROM ENERGY_USE ;";

$result = mysqli_query($con,$sql_select);

 $row = mysqli_fetch_array($result);
 echo $row[0];

 
// if()
// {
//     //$userID =$row["ID"];
//     header('Content-Type: application/json; charset=utf8');
//     $json = $row[0]; //json_encode(array("Rank"=>$response), JSON_PRETTY_PRINT+JSON_UNESCPED_UNICOCDE );
//     echo $json;
    
// }
  
//$sql = "SELECT ID,user_ID,friend_ID,friend_name,'{$userID}' AS meID FROM friend_list WHERE user_ID ='{$userID}' OR friend_ID = '{$userID}' ;";


 



 $response = array();

while($row = mysqli_fetch_array($result))
{
    
    
    array_push($response,array('nation'=>$row["nation"],'first_energy'=>$row["first_energy"],'power_consumption'=>$row["power_consumption"],'first_energy_perperson'=>$row["first_energy_perperson"],'power_consumption_per_person'=>$row["power_consumption_per_person"] ));
}



header('Content-Type: application/json; charset=utf8');
$json = json_encode(array("ENGERGY"=>$response), JSON_PRETTY_PRINT+JSON_UNESCPED_UNICOCDE );
echo $json;
echo $sql_select;

?>