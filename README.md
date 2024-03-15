# Introduction 
Seeking help to resolve a marshalling issue which surfaced when an exported function with strinn argument in an unmanged shared library is PInvoked from c# code.
stackoverflow issue url : https://stackoverflow.com/questions/78162106/p-invoke-c-exported-function-from-c-sharp-library-char-emty-in-dll?noredirect=1#comment137805770_78162106

# Getting Started
1. System must have cmake for Windows and c++ compiler that supports c++17.
2. System must have a way to create and build a c# project. Possibly Visual Studio.

# Build c++ Project
1. Clone the repository and navigate to 'master-project/build' directory. Run 'cmake .. -A x64' command here.
2. The system must have a c++17 compiler to build the project. Run 'cmake --build . --config Debug' frome same directory.
3. Previous step will build binaries in 'master-project/bin' directory.
4. Execute the master-project.exe to test the library.

# Build c# Project
1. Create a new console application project in c#. 
2. Copy the code from 'main.cs' file in 'master-project/c#-code' directory of this repository.
3. Paste the code to entry-point file in c# project.
4. Build the c# project for x64 architecture.
5. To test the PInvoke from c#, copy the 'sub-project.dll' built in c++ project to the same directory where the application executable is built by c# project.
6. Now run/debug the c# application.

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
