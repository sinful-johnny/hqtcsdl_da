@echo off
cls
chcp 65001

REM POPULATING DATA
@echo ---- Populating RielData...
SQLCMD -E -dmaster -f65001 -i".\DATA\fake date riel.sql"

PAUSE