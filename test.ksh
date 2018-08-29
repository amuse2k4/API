#!/bin/ksh

echo ""
echo ""
echo "-----Started.  `date`"

D7INVP1_ARCHIVE_HOLD=C:\Users\amuse\Documents\ScriptTestAchive
D7INVP1_ARCHIVE=C:\Users\amuse\Documents\ScriptTest
DATE=`date +"%b"`


echo "-----Archive Jul IES Files. `date`"
ls -l $D7INVP1_ARCHIVE | grep IES | grep Jul |
awk ' { print $9 }' |
while read line
do	
      mv $D7INVP1_ARCHIVE/$line $D7INVP1_ARCHIVE_HOLD
done

echo "-----Ended.  `date`"
