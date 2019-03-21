Things this program needs to do:

* Take a group of conditions and return a true/false based on all the conditions and their configuration


Rules it must follow:

* An empty list must return true
* Items in a group must be tested independantly
* Must connect multiple items with connectors (AND/OR)
* 


Strategies:
* Take first item and test if it is within a group
* If in group find that items group and test that group (Go to the beginning)



Tests:

( ValueOne      =   10   OR
  ValueFive     =   5  ) AND
  ValueThree    =   3    AND

Answer True

( ValueOne     =    2     OR     
( ValueThree   =    3     AND
  ValueOne     =    1  )  OR
  ValueFive    =    5  )  AND

Answer True
