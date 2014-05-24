//Sort 3 real values in descending order using nested if statements.

jsConsole.writeLine("Enter three numbers separated by single space.");

document.getElementById("submit").onclick = sortNumbers;

function sortNumbers() {
	var numbers = document.getElementById("input").value.split(" ");

	var first = parseFloat(numbers[0]),
		second = parseFloat(numbers[1]),
		third = parseFloat(numbers[2]);
		temp = 0;

	if (first < second) {
		temp = first;
		first = second;
		second = temp;
	};

	if (second < third) {
		temp = third;
		third = second;
		second = temp;
	};

	if (first < second) {
		temp = second;
		second = first;
		first = temp;
	};	

	jsConsole.writeLine("sorted numbers: " + first + ", " + second + ", " + third);
};