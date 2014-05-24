//Write a function that returns the last digit of given integer as an English word.

jsConsole.writeLine("Enter number.");

document.getElementById("submit").onclick = function() {jsConsole.writeLine(lastDigitToString(document.getElementById("input").value));};

function lastDigitToString(number) {
	var	digit;

	switch (number[number.length - 1]){
		case "0": digit = "zero"; break;
		case "1": digit = "one"; break;
		case "2": digit = "two"; break;
		case "3": digit = "three"; break;
		case "4": digit = "four"; break;
		case "5": digit = "five"; break;
		case "6": digit = "six"; break;
		case "7": digit = "seven"; break;
		case "8": digit = "eight"; break;
		case "9": digit = "nine"; break;
		default: digit = "wrong input"; break;
	}

	return digit;
};