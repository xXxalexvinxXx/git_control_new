<?php

// Declared in ascending order, or sort ascending before using

$step[0] = 3;

$step[1] = 5;

$step[2] = 15;

// Now get to work. Build the 1 to 100 array

for ($i = 1; $i<=100; $i++) {

	$theList[$i] = $i;

}

// Mark the "Fizz"es

for ($i = $step[0]; $i <= 100; $i = $i + $step[0]) {

	$theList[$i] = "Fizz";


}

// Mark the "Buzz"es

for ($i = $step[1]; $i <= 100; $i = $i + $step[1]) {

	$theList[$i] = "Buzz";


}

// Mark the "FizzBuzz"es

for ($i = $step[2]; $i <= 100; $i = $i + $step[2]) {

	$theList[$i] = "FizzBuzz";


}

var_dump($theList);

?> 
