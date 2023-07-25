V
<?php
//Check if the method is GET or POST
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['name'];
    $email = $_POST['email'];
    $phone = $_POST['phone'];

    //Connect the database
    $conn = new mysqli('localhost:3306', 'root', '', 'dbdw');
    if ($conn) {
        echo 'Connection Sucessful..';

        $sql = "INSERT INTO `users` (`name`, `email`, `phone`) VALUES ('$name', '$email', '$phone')";
        $results = mysqli_query($conn, $sql);

        //Check the condition for the results
        if ($results) {
            echo ', Data inserted sucessfully...';
        } else {
            die(mysqli_error($conn));
        }
    } else {
        die(mysqli_error($conn));
    }
}
?>