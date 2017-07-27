# ScrObjAnalyzer
Analyzes fumen-sobj file which is derived from scrobj file of MLTD.

Written things under are the code rule.

## Track

    -1                        (block data)  
    0                         (null)  
    1, 2                      2Mix  
    3, 4                      2Mix+  
    9, 10, 11, 12             4Mix  
    25, 26, 27, 28, 29, 30	  6Mix  
    31, 32, 33, 34, 35, 36	  MillionMix

## Type

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

## StartPos

ranges from -1 to n in nMix mode.

## EndPos

ranges from 0 to n-1 in nMix mode.

## Specific explanation

Note whose type is 5, 6 or 7 has information of their 'tail' notes also.

    5, 7    EndType is their tail note's type.
    6       (Not implemented) there is an array of the information for tail notes.
