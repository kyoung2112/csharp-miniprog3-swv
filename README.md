## C# Express SWV Printf Viewer for Miniprog3 ##

This is a SWV Printf Viewer for Miniprog3. It is based on the SWV example provided with PSoC Programmer. It is a work in progress.

The project is built using Visual C# 2010 Express, which is available for free from Microsoft: http://www.visualstudio.com/en-us/downloads/download-visual-studio-vs

The current functionality receives single bytes written to the LSB of stimulus register 0 and written out over SWV. It prints them to the text window. The GUI has selection capability for the following MiniProg3 settings:

- Manchester or UART (fixed 6 MHz frequency)
- Miniprog3 voltage 5V, 3.3V, 2.5V, 1.8V, or Ext (no power applied)
- Miniprog3 10-pin or 5-pin header
- Synchronous or asynchronous transfer mode. In the synchronous mode, the data is repeatedly received (in the thread) from the slave using the SWV_ReadData() API. In the asynchronous mode, the data is received from the slave via the event mechanism.

The accompanying firmware for the PSoC3 and PSoC5LP can be found here: https://github.com/kyoung2112/psoc_creator_swv_firmware

**NOTE: The program is currently manually bound to PP_COM_Wrapper.dll that is installed with PSoC Programmer. When building for the first time (and after updating PSoC Programmer), you need to update the reference. Doing this requires the following process: In the solution explorer, right click on "References", choose "Add Reference…" and browse to "C:\Program Files (x86)\Cypress\Programmer\PP_COM_Wrapper.dll".**

I'm told that if the DLL references are changed to the "PP_ComLib_Wrapper.dll" which also installs with PSoC Programmer, it becomes version neutral and will work with future versions of PSoC Programmer without requiring updated references. I hope somebody can help with this!
