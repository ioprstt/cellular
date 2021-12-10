FROM mysql/mysql-server

EXPOSE 3306

ADD mysqld.cnf /etc/mysql/mysql.conf.d/mysqld.cnf

CMD ["--default-authentication-plugin=mysql_native_password"]
