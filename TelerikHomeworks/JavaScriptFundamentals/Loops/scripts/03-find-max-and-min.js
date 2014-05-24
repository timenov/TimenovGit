//Write a script that finds the max and min number from a sequence of numbers.

jsConsole.writeLine("Enter several numbers separated by single space.");

document.getElementById("submit").onclick = findMinAndMax;

function findMinAndMax() {
	var numbers = document.getElementById("input").value.split(" "),
		i,
		min = parseFloat(numbers[0]),
		max = parseFloat(numbers[0]);

	for (i = 1; i < numbers.length; i++) {
		if (parseFloat(numbers[i]) > max) {
			max = parseFloat(numbers[i]);
		};

		if (parseFloat(numbers[i]) < min) {
			min = parseFloat(numbers[i]);
		};
	};

	jsConsole.writeLine("<br />min: " + min + "<br />max: " + max);
};