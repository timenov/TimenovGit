//Write a function that reverses the digits of given decimal number. Example: 256 -> 652

jsConsole.writeLine("Enter number.");

document.getElementById("submit").onclick = function() {jsConsole.writeLine(reverseDigits(document.getElementById("input").value));};

function reverseDigits(number) {
	var reversed = "",
		i;

	for (i = number.length - 1; i >= 0; i--) {
		reversed += number[i];
	}

	return reversed;
};