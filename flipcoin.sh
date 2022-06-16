randomnum1=$(((RANDOM%899)+100))
randomNum2=$(((RANDOM%899)+100))
randomNum3=$(((RANDOM%899)+100))
randomNum4=$(((RANDOM%899)+100))
randomNum5=$(((RANDOM%899)+100))

echo "First Number is " $randomnum1
echo "Second Number is " $randomNum2
echo "Third Number is " $randomNum3
echo "Fourth Number is " $randomNum4
echo "Fifth number is " $randomNum5

if [ $randomnum1 -gt $randomNum2 ]&&[ $randomnum1 -gt $randomNum3 ]&&[ $randomnum1 -gt $randomNum4 ]&&[ $randomnum1 -gt $randomNum5 ]
then
echo $randomnum1 "is greater"
elif [ $randomnum2 -gt $randomNum1 ]&&[ $randomnum2 -gt $randomNum3 ]&&[ $randomnum2 -gt $randomNum4 ]&&[ $randomnum2 -gt $randomNum5 ]
then
echo $randomNum2 "is greater"

elif [ $randomnum3 -gt $randomNum1 ]&&[ $randomnum3 -gt $randomNum2 ]&&[ $randomnum3 -gt $randomNum4 ]&&[ $randomnum4 -gt $randomNum5 ]
then
echo $randomNum3 "is greater"

elif [ $randomnum4 -gt $randomNum1 ]&&[ $randomnum4 -gt $randomNum2 ]&&[ $randomnum4 -gt $randomNum3 ]&&[ $randomnum4 -gt $randomNum5 ]
then
echo $randomNum4 "is greater"

else
echo $randomNum5 "is greater"
fi

