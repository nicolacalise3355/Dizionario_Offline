<?php 

require_once "connection.php";

function findKey($connessione, $key){
    $query_ricerca = "SELECT * FROM keys WHERE key = '$key'"; 
    $results = $connessione->query($query_ricerca);
    if($results->num_rows > 0){
        return true;
    }else{
        return false;
    }
}

$key = $_POST['key'];
$response = [];

$res = findKey($connessione, $key);
if($res == true){
    $response['response'] = true;
}else{
    $response['response'] = false;
}

echo json_encode($response);

?>