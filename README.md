# NP - A Faster Way to Launch Notepad

As a software developer, I spend a significant amount of my day at the Windows command prompt. I also spend a lot of time in Notepad - so it's not surprising that I want to launch Notepad from the command prompt. Of course, you can do this by just typing "notepad" or "notepad filename".

## Opening Multiple Files

That's fine, but sometimes I want to open multiple files at once. NP will let you do this - just type "np file1 file2 ... fileN".

## Opening Command Output

Sometimes, I want to examine the output of a command more closely. Copying and pasting from the command prompt application is rather fiddley, and causes lines to be wrapped. Luckily, you can pipe commands to clip.exe. For example, "dir c:\ | clip". This is really handy, and I use this tool a lot. However, every time I use Clip, I immediately open notepad, and paste the clipboard contents.

NP helps here too - simply pipe the command output to NP, and you'll see the output in Notepad. For example: "dir c:\ | np".

## Using a Different Text Editor

In the above, I've talked about Notepad, as that's the text editor I use for reading/simple editing of text files. A friend asked me if I would make it work with other text editors - so now you can specify the full path to your prefered editor in the "editor" environment variable. You can do this in Control Panel -> System -> Advanced -> Environment Variables.

## Feedback

I wrote this small tool in just a few minutes one afternoon, but found it rather handy - so I'm posting it publicly in case anyone else finds it useful.

If you have any feedback, please email "me" at the domain SaqibShaikh.com.

