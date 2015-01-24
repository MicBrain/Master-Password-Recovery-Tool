Master Password Recovery Tool 
=============================

### Table of Content

1. Description of the Software
2. Ongoing Research Project
3. References
 
### Description of the Software 

Like any reasonably developed system, HDD and BIOS systems on laptops/notebooks need enormous protection. Systems that are using password generators in order to protect their security are using different algorithms. Algorithms can vary based on their difficulty level. Current generation laptops require good password generators in order to make their systems as safe as possible.
<img src="https://cloud.githubusercontent.com/assets/5885065/5726188/578acd5c-9b0e-11e4-870a-3ecc4bdbab3d.gif"
 alt="algo Logo" title="algo" align="right" />
Majority of all laptops are using master passwords (which are unique in each laptop) in order to protect their systems. In order to penetrate the BIOS system one should find a way to disable BIOS passwords. Sometimes it can be very important for the laptop users to know the master passwords of their laptops. However the algorithms to figure out the password are not available to every user.

When a laptop is locked with password, a checksum of that password is stored in FlashROM - this is a chip on the mainboard of the device which also contains the BIOS code and other settings, e.g. memory timings. For most brands, this checksum is displayed after entering an invalid password for the third time. The dramatic 'System Disabled' message is just scare tactics: when you remove all power from the laptop and reboot it, it will work just as before. From such a checksum (also called "hash"), valid passwords can be found by means of brute-forcing. The bypass mechanisms of other vendors work by showing a number to the user from which a master password can be derived. This password is usually a sequence of numbers generated randomly. 

This software generates and calculates the Master Passwords of HDD and BIOS systems of ACER, Dell and Sony VAIO laptops according to their license numbers. The program takes the license numbers of those laptops(which are unique for every laptop) as an input and gives themaster codes of HDD and BIOS as an output. The algorithm was figured out by multiple testing and collecting data from different Internet sources.

### Ongoing Research Project

This software has been written by [Rafayel Mkrtchyan][web1]. To try the beta version of the application you can download **Password Recovert Tool 1.0.exe** file from this repo. To read about the algorithms that different companies used for protecting their Master Passwords download **Description.pdf** file. I started researching the mechanics of BIOS and HDD password in current generation laptops in 2012. My goal was to create a set of master password generators to disable Basic Input /Output System (BIOS) passwords. After understanging the general algorithm for generating Master Passwords I tried to test them from collected data from different Internet sources.

You are welcome to contribute to this research project. Look at existing code to   Here's some examples of things you might want to make a pull request for:
* New fixes,
* New tests,
* Bugfixes,
* Inefficient blocks of code.

### References

[web1]: https://www.linkedin.com/in/rafayelmkrtchyan
