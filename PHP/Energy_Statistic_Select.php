<?php 
 require_once "DBconnection_E.php";

 $con = mysqli_connect($host,$db_user,$db_password,$db_name);

 mysqli_query($con,'SET NAMES utf8');

$Rank = $_POST["Rank"];


if(mysqli_connect_error($con))//연결오류시 
{
    echo "Failed to connect to MySQL: " . mysqli_connect_error();

}


//유저ID번호 얻기

$sql_select = "SELECT nation,coal,oil,naturalgas,electricity,heat,other,final  ,RANK() over(ORDER BY final DESC) AS ranking  FROM EnergyStatistics ORDER BY final DESC ;";

$result = mysqli_query($con,$sql_select);

 //$row = mysqli_fetch_array($result);
// echo $row[0];

 
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
    if($Rank == $row["ranking"])
    {
        array_push($response,array( 'ranking'=>$row["ranking"],'nation'=>$row["nation"],'coal'=>$row["coal"],'oil'=>$row["oil"],'naturalgas'=>$row["naturalgas"],'electricity'=>$row["electricity"],'heat'=>$row["heat"],'other'=>$row["other"],'final'=>$row["final"] ));

    }
    
}



header('Content-Type: application/json; charset=utf8');
$json = json_encode(array("ENERGY"=>$response), JSON_PRETTY_PRINT+JSON_UNESCPED_UNICOCDE );
echo $json;
//echo $sql_select;
//echo $Rank;


?>