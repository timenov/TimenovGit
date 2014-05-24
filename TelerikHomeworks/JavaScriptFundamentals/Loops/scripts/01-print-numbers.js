//Write a script that prints all the numbers from 1 to N.

document.getElementById("submit").onclick = printNumbersTo;

function printNumbersTo() {
	var number = document.getElementById("input").value,
		i;
	for (i = 1; i <= number; i++) {
		jsConsole.write(i + " ");
	};
};