# ReqMaker
**ReqMaker is a fast and simply requirements.txt generator for python maded in C#.**
# How ReqMaker work?
**ReqMaker read your python file and create a new requirements.txt file that contains all the pips necessary for the correct work of your python program.**
# Usage
**Command pattern:**
```
C:\> ReqMaker <fileName>.py
```
##
**Before:**
```
=============
main.py
=============
```
###
**Start ReqMaker:**
```
C:\> ReqMaker main.py
```
###
**After:**
```
=================
main.py
requirements.txt
=================
```
#
**main.py:**
```python
import os
import sys, json
from colorama import Fore, Style
import time.sleep
```
###
**requirements.txt:**
```
os
sys
json
colorama
time
```
# Known bugs:
- None
# Working on:
- None
