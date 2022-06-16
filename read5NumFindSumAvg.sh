randomnum1=$(((RANDOM%11)+10))
randomNum2=$(((RANDOM%11)+10))
randomNum3=$(((RANDOM%11)+10))
randomNum4=$(((RANDOM%11)+10))
randomNum5=$(((RANDOM%11)+10))


sum=$((randomnum1+randomNum2+randomNum3+randomNum4+randomNum5))
echo "First random Number is:" $randomnum1
echo "Second random Number is:" $randomNum2
echo "Third random Number is:" $randomNum3
echo "Fourth random Number is:" $randomNum4
echo "Fifth random Number is:" $randomNum5
echo "Sum is" $sum
num=5
avg=($sum/$num)
echo "Avg is" $avg


