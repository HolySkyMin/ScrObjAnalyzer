# ScrObjAnalyzer
Analyzes fumen-sobj file which is derived from scrobj file of MLTD.

This program is not perfect still. I'm trying hard but there are possibilities of erroneous exporting.

## Features

This program supports exploring \*\*\*\*\*\*\_fumen\_sobj.txt (which is originally JavaScript file I think) and exporting its core feature in TWx format.  
2Mix and 2Mix+ will be exported as TW2, 4Mix will be exported as TW4, 6Mix and Million Mix will be exported as TW6.  
(Tempest Wave will support TW2 and TW4 in their later update.)

## Known problems

In 1.1.1:
* Data which contains more than 2 EventConductorData will be exported incorrectly.

## Data rules

### Track

    -1                        (block data)  
    0                         (conductor data)  
    1, 2                      2Mix  
    3, 4                      2Mix+  
    9, 10, 11, 12             4Mix  
    25, 26, 27, 28, 29, 30	  6Mix  
    31, 32, 33, 34, 35, 36	  MillionMix

### Type

    0   Small tap note
    1   Large tap note
    2   Left Flick note
    3   Up flick note
    4   Right flick note
    5   Small hold note
    6   Small slide note
    7   Large hold note
    8   Special note

There is no Large slide note.

### StartPos

ranges from -1 to 2 in 2Mix/2Mix+ mode, -2 to 5 in 4Mix mode, and -2 to 7 in 6Mix/Million Mix mode.
Allows decimal number.

### EndPos

ranges from 0 to n-1 in nMix mode.
Allows decimal number.

### Specific explanation

Note whose type is 5, 6 or 7 has information of their 'tail' notes also.

    5, 7    EndType is their tail note's type.
    6       (Not shown in list) there is an array of the information for tail notes.
