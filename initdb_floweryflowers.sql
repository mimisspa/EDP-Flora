ALTER USER 'root'@'localhost' IDENTIFIED BY 'mike';
CREATE DATABASE floweryflowers;
GRANT ALL PRIVILEGES ON floweryflowers.* TO 'root'@'localhost';
FLUSH PRIVILEGES;