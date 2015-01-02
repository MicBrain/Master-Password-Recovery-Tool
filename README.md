Master-Password-Recovery-Tool
=============================

An application that recovers the Master Passwords of Laptops.

Description
---------------

When a laptop is locked with password, a checksum of that password is stored in FlashROM - this is a chip on the mainboard of the device which also contains the BIOS code and other settings, e.g. memory timings. For most brands, this checksum is displayed after entering an invalid password for the third time. The dramatic 'System Disabled' message is just scare tactics: when you remove all power from the laptop and reboot it, it will work just as before. From such a checksum (also called "hash"), valid passwords can be found by means of brute-forcing. The bypass mechanisms of other vendors work by showing a number to the user from which a master password can be derived. This password is usually a sequence of numbers generated randomly. -- Dogbert's Blog, May 2, 2009


 Project 
----------
 
This application is designed to recover the master password of ACER, Sony Vaio and Dell laptops according to their licence numbers. Licence numbers for each laptop is absolutely unique, and this program helps to figure out the corresponding master passwords of those laptops. The algorithm was decoded by multiple testing and collecting data from different internet sources. -- Rafayel Mkrtchyan, Junyu Wang, 5/3/2014.
