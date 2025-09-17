# SingleFileGenerator Test

This is a project to show a working VS Extension with a SingleFileGenerator to reproduce this working with VS2022 but not working in VS2026.

The `SimpleSingleFileGenerator` project works with `*.txt` files.
The Sample project includes an otherwise empty project that contains such a file.

Use the extension in VS2022, open the sample project and modify the .txt file and you'll see the nested file be automatically updated.
Do the same thing in VS2026 and the nested file won't be updated when the original file is saved. If you try and run the custom tool directly you'll get the error message "Cannot find custom tool 'FileGenerator' on this system.".
