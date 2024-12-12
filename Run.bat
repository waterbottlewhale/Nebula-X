@echo off
set count=0

:loop
start
set /a count+=1
if %count%==250 goto end
goto loop

:end
echo Done
