openssl genrsa -out arco.key 2048
openssl req -new -key arco.key -subj "/C=AR/O=ARMENDARIZ RUBEN MARIO/CN=RUBEN4/serialNumber=CUIT 20111732311" -out arco.csr
pause 
