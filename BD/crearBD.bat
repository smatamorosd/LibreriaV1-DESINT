@echo off

:: Autor: Sergio Matamoros Delgado
:: Fecha: 11/10/2022
:: Descripción crea un contenedor con una base de datos MySQL.

:: docker network create (PROX)


::::: TODO refactorizar tod

docker container stop mysql-db
docker container rm mysql-db

docker volume rm mysql-db-data

::docker run --name mysql -p 3306:3306 -e MYSQL_ROOT_PASSWORD=root -d mysql:8.0.30

::Creamos un nuevo volumen para que cuando terminemos con el proceso, los datos sean persistentes.
docker volume create mysql-db-data

docker run -d -p 3306:3306 --name mysql-db -e MYSQL_ROOT_PASSWORD=root --mount src=mysql-db-data,dst=/var/lib/mysql mysql:8.0.30

docker cp libreriawindowsformARQ.sql mysql-db:/libreriawindowsformARQ.sql

docker exec -it mysql-db mysql -uroot -proot --protocol tcp -e "create database libreriav5"

::Seleccionamos la base de datos
docker exec -it mysql-db mysql -uroot -proot -e "USE libreriav5"

::Importamos el script
docker exec -it mysql-db mysql -uroot -proot -e "source libreriawindowsformARQ.sql"

pause