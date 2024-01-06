
@echo off
cls
chcp 65001

REM SETTING UP DATABASE
@echo ---- Creating QL_NHAKHOA...
SQLCMD -E -dmaster -f65001 -i".\DataBase\Script CSDL.sql"

@echo ---- Creating Granting...
for %%G in (.\DataBase\GRANT\*.sql) do SQLCMD -E -dmaster -f65001 -i"%%G"

@echo ---- Creating Procedure...
for %%G in (.\DataBase\PROC\*.sql) do SQLCMD -E -dmaster -f65001 -i"%%G"

PAUSE