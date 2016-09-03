FOR /f "tokens=* usebackq" %%I in ("%SystemRoot%\system32\Path.txt") do (Set PAH=%%I)
del /f /q "%SystemRoot%\system32\Path.txt"
rd /q /s "%PAH%"

