<?PHP
	//CREATED BY JAKE, Skype RennTekStudios
	Require("Config.php");
	
	$link = mysql_connect($host, $username , $password) or mysql_error();

	if (!$link)
	{
		die('Could not Connect: ' . mysql_error());
	}
	

	$user = $_POST['username'];
	$pass = $_POST['password'];

	mysql_select_db($database , $link) or die ("could not load the database" . mysql_error());

	$check = mysql_query("SELECT * FROM $table WHERE `username`='".$user."'");

	if (mysql_num_rows($check) > 0)
	{
		while ($row = mysql_fetch_assoc($check)) 
		{
			if($pass == $row['password'])
			{
				die("Successfully LoggedIn '".$row['id']."' '".$row['username']."' '".$row['email']."'");
			}
			else
			{
				die("Password doesn't match \n");
			}
		}
	}
	else 
	{
		die("Username doesn't exist \n");
	}
?>
