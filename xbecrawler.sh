#!/usr/bin/bash
clear                                   # Clear the screen.
                                        
echo -e '\E[37;44m'"\033[1mListing XBE\033[0m" #colors (blue back, white foreround)
echo -e '\E[38;42m'"\033[1m" #start with green backgroudn
echo ======================== Xbe file ================================
ls -l | grep "\.xbe$" -i #list all Xbe files, upper or lower

echo ======================== exe file ================================
ls -l | grep "\.exe$" -i #list all exe files, upper or lower
echo ======================== dll file ================================
ls -l | grep "\.dll$" -i #list all dll files, upper or lower
echo ======================== bin file ================================
ls -l | grep "\.bin$" -i #list all bin files, upper or lower

echo ======================== xex file ================================
ls -l | grep "\.xex$" -i #list all bin files, upper or lower

echo ======================== Sub folders =============================
folders=$(ls -l | grep '^d' | awk '{ print $9 }') #list all folders
echo $folders
echo ==================================================================
echo -e "\033[0m" #end of the green backgroudn
echo  -e '\E[37;44m'"\033[1mdone\033[0m"
files=$(ls | grep "\.xbe$" -i)
#files=xboxdash.xbe
for fily in $files
do
   echo  -e '\E[37;44m'"\033[1mecho $fily\033[0m"
  echo Testing for C: #take fily and string test content for c:\
  strings -a $fily | grep -i -a "c:\\\\"
  echo Testing for D:
  strings -a $fily | grep -i -a "d:\\\\"

  echo  -e '\E[37;44m'"\033[1mend of $fily\033[0m"
done
if [ "$folders" != "" ]
  then
    echo "there are folders"
fi
echo
echo  -e '\E[37;44m'"\033[1mDone\033[0m"
tput sgr0                               # Reset colors to "normal."

echo

exit 0