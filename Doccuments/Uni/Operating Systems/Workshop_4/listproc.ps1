if ($args.length -eq 2){
	Get-Process | findstr $args[0] | Out-File -FilePath $args[1]
	
}
else {
	echo "Not enough arguments"
}