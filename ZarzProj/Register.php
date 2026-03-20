<?PHP
//CREATED BY JAKE, Skype RennTekStudios
	Require("Config.php");
	
	$user = $_POST['username'];
	$pass = $_POST['password'];
	$email = $_POST['email'];
	
	$link = mysql_connect($host, $username , $password) or mysql_error();

	if (!$link)
	{
		die('Could not Connect: ' . mysql_error());
	}
	   
	mysql_select_db($database , $link) or die ("could not load the database" . mysql_error());
	 
	$check = mysql_query("SELECT * FROM $table WHERE `username`='".$user."'" ) or die (mysql_error());

	if(mysql_num_rows($check) == 0)
	{
		if($user != null)
		{
			if($pass != null)
			{
				if($email != null)
				{
					$query = mysql_query("INSERT INTO $table ( `id` , `username` , `password` , `email`) VALUES ( '' , '$user' , '$pass' , '$email') ; ");
					if($query)
					{
						die ("Successfully created account!");
					}
					else
					{
						die ("Error: " . mysql_error());
					}
				}
				else
				{ 
					echo("Invalid email");
				}
			}
			else
			{
				echo("Invaid password");
			}
		}
		else
		{
			echo("Invalid username");
		}
	}
	else
	{
		die("User already exists!");
	}
 ?>