ScrObjAnalyzer is a tool that analyzes ******_fumen_sobj.txt file, which is zipped in scrobj_******.unity3d.#$%@... file of MLTD.

Written things under are the code rule.

==============================================

Track

-1			(block data)
0			(null)

1, 2			2MIX
3, 4			2MIX+

9, 10, 11, 12		4MIX

25, 26, 27, 28, 29, 30	6MIX
31, 32, 33, 34, 35, 36	MillionMix

==============================================

Type

0	Small tap note
1	Large tap note
2 3 4	Flick note (Left, Up, Right?)
5	Small hold note
6	Small slide note
7	Large hold note
8	Special note

There is no Large slide note.

==============================================

StartPos

ranges from -1 to n in nMix mode.

==============================================

EndPos

ranges from 0 to n-1 in nMix mode.

==============================================

Specific explanation

Note whose type is 5, 6 or 7 has information of their 'tail' notes also.

5, 6	EndType is their tail note's type.
7	(Not implemented) there is an array of the information for tail notes.

==============================================