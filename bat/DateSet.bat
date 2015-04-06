@SET IPorHostname=192.168.1.1
@SET /p GunName=[Number of Iterations]
@SET Password=9ot@mmo?
@SET Date=030303002014
@curl -v -d'{"param":"%Date%"}' -H "Content-Type: application/json" http://192.168.1.1/dateset/