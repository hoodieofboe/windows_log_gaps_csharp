This is the C# version of Rob Vandenbrink's PowerShell script to find gaps in Windows Event Logs. The original script can be found here: https://github.com/robvandenbrink/windows_log_gaps.

This was created as an independent research project into how much faster would a C# program accomplish this task and later turned into the question of when should a tool be a PowerShell script or a complied executable.

This has not been tested in an environment were event logs have been deleted (lack of time) and has a different log count then the script (could be an error in the C#, could be an error with how I edited the original script to count logs).