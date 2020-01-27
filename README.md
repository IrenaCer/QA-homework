# Visma QA homework task

There are two ways you can install this application in your machine: Use the already created executable file or build one yourself.

## Using executable file

1. Download or clone the project:
  * Clone: 
    1. Execute `git clone git@github.com:IrenaCer/QA-homework.git` in your terminal.
  * Download:
    1. Download from [Github](https://github.com/IrenaCer/QA-homework/archive/master.zip). 
    2. Unzip the package `QA-homework-master.zip` using your preferred method.
2. Star the program:
  * On Windows:
    1. Go to `{YOUR_CHECKOUT_DIRECTORY}/QA-homework/QA-homework/bin/Release`.
	  2. Double click `QA-homework.exe`
  * On Mac/Linux:
    1. Go to `{YOUR_CHECKOUT_DIRECTORY}/QA-homework/QA-homework/bin/Release` through the terminal.
    2. Execute `mono QA-homework.exe`. If you need to install mono, you can download it from [mono website](https://www.mono-project.com/download/stable/).

## Building from source

1. Download or clone the project:
  * Clone:
    1. `git clone git@github.com:IrenaCer/QA-homework.git`.
  * Download:
    1. Download from [Github](https://github.com/IrenaCer/QA-homework/archive/master.zip). 
    2. Unzip the package `QA-homework-master.zip` using your preferred method.
2. Navigate to `{YOUR_CHECKOUT_DIRECTORY}/QA-homework` on your terminal.
3. Execute `csc -out:QA-homework.exe Program.cs Menu.cs NumberList.cs NumberReader.cs` to build the program.
4. Execute `mono QA-homework.exe` to start the progam.

*Note: If `csc` or `mono` command is missing please download it from [mono website](https://www.mono-project.com/download/stable/).*
