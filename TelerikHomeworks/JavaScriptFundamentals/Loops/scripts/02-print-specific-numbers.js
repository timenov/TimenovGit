//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

document.getElementById("submit").onclick = printNumbersTo;

function printNumbersTo() {
	var number = document.getElementById("input").value,
		i;
	for (i = 1; i <= number; i++) {
		if (i % 21 !== 0) {
			jsConsole.write(i + " ");			
		};
	};
};