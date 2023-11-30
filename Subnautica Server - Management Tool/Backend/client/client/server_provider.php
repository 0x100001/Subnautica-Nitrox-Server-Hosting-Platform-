<?php
$link = mysqli_connect("127.0.0.1", "admin_rdp_user","QrPP3FOzqa2SWGZGcyjzyf4EIKzESomm");
$database = mysqli_select_db($link, "admin_rdp_db");

$currentDate = new DateTime();

$user = $_GET['username'];
$password_provided = $_GET['password'];
$hwid = $_GET['hwid'];
$tables = "user";

$rdp_server_request = $_GET['rdp_s'];
$rdp_port_request = $_GET['rdp_p'];
$rdp_user_request = $_GET['rdp_u'];
$rdp_password_request = $_GET['rdp_pp'];
$customer_name_request = $_GET['c_n'];
$openvpn_profile_request = $_GET['o_p'];

$sql = "SELECT * FROM ". $tables ." WHERE username = '". mysqli_real_escape_string($link,$user) ."'" ;
$result = $link->query($sql);
if ($result->num_rows > 0) {
    // Outputting the rows
    while($row = $result->fetch_assoc())
    {
        function Redirect($url, $permanent = false)
        {
            if (headers_sent() === false)
            {
                header('Location: ' . $url, true, ($permanent === true) ? 301 : 302);
            }
        exit();
        }
        
        if ($password_provided == $row['password'])
        {
			//echo "687c6546v968057nv58z6b85897vn589v6"; //password correct

            if($row['banned_reason'] != "")
            {
                //echo "6x58b4654x62b537x45bxb523654x236b546"; // user banned
            }
			else
			{				
				//Licence expire check.
            	$endDate = new DateTime($row['licence_expire']);            
        		if ($currentDate < $endDate)
        		{
        			//echo "g" . $row['licence_type'];
					
					if (strlen($row['hwid']) > 1)
					{
						if ($hwid != $row['hwid'])
						{
							//echo "5346578x43656v37cm8943v673465c5643tr74t"; // Wrong
						}
						else
						{
							//echo "648cm66v75v9677774cm7689vm8956b7m894v689548"; // Correct
							
							if($rdp_server_request == "1")
							{
								echo $row['rdp_server']; 
							}
							
							if($rdp_port_request == "1")
							{
								echo $row['rdp_port']; 
							}
							
							if($rdp_user_request == "1")
							{
								echo $row['rdp_user']; 
							}
							
							if($rdp_password_request == "1")
							{
								echo $row['rdp_password']; 
							}
							
						    if($customer_name_request == "1")
							{
								echo $row['customer_name']; 
							}
							
			                if($openvpn_profile_request == "1")
							{
								echo $row['openvpn_profile']; 
							}
						}
					}
					else
					{
						$sql = "UPDATE ". $tables ." SET hwid='$hwid' WHERE username='$user'";
						if(mysqli_query($link, $sql))
						{
							echo $row['hwid'];
							//echo "4c675897m5v087m489v65857v5467v854mv68"; // HWID Set
						}
						else
						{

						}
					}
        		}
				else 
				{
        			//echo "7943x536n5c7843n65c78643785c"; //expired
				}
			}
        }
    }
}  
?>