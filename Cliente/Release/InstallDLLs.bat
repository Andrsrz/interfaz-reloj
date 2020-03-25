@echo OFF

reg Query "HKLM\Hardware\Description\System\CentralProcessor\0" | find /i "x86" > NUL && set OS=32BIT || set OS=64BIT

if %OS%==32BIT (
    echo Copiando archivos...
) else if %OS%==64BIT (
    echo Copiando archivos...
    Copy sdk\commpro.dll sdk2\commpro.dll
    Copy sdk\comms.dll sdk2\comms.dll
    Copy sdk\plcommpro.dll sdk2\plcommpro.dll
    Copy sdk\plcomms.dll sdk2\plcomms.dll
    Copy sdk\plrscagent.dll sdk2\plrscagent.dll
    Copy sdk\plrscomm.dll sdk2\plrscomm.dll
    Copy sdk\pltcpcomm.dll sdk2\pltcpcomm.dll
    Copy sdk\rscagnet.dll sdk2\rscagnet.dll
    Copy sdk\rscomm.dll sdk2\rscomm.dll
    Copy sdk\tcpcomm.dll sdk2\tcpcomm.dll
    Copy sdk\usbcomm.dll sdk2\usbcomm.dll
    Copy sdk\zkemkeeper.dll sdk2\zkemkeeper.dll
    Copy sdk\zkemsdk.dll sdk2\zkemsdk.dll
)

pause

rem regsvr32 C:\WINDOWS\SysWOW64\zkemkeeper.dll