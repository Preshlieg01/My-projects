<!DOCTYPE html>

<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registration form</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css"
        integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
</head>
<h1>School Registration</h1>
<br>

<body>
    <form action='connect.php' method="POST">
        <label for="user"> Name: </lable> <br>
            <input type='text' name='name' id="name" required /> <br> <br>

            <label for="email">Email: </lable> <br>
                <input type='email' name='email' id="email" required /> <br> <br>

                <label for="phone">Phone: </lable> <br>
                    <input type='text' name='phone' id="phone" required /> <br> <br>



                    <input type='submit' name='submit' id='submit' />

</body>

</html>