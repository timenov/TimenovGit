//Write a script that finds the greatest of given 5 variables.

jsConsole.writeLine("Enter five numbers separated by single space.");

document.getElementById("submit").onclick = greatestNumber;

function greatestNumber() {
	var numbers = document.getElementById("input").value.split(" ");

	var first = parseFloat(numbers[0]),
		second = parseFloat(numbers[1]),
		third = parseFloat(numbers[2]),
		fourth = parseFloat(numbers[3]),
		fifth = parseFloat(numbers[4]),
		greatest = first;

		if (second > greatest) {
			greatest = second;
		};

		if (third > greatest) {
			greatest = third;
		};

		if (fourth > greatest) {
			greatest = fourth;
		};

		if (fifth > greatest) {
			greatest = fifth;
		};
	

	jsConsole.writeLine("greatest number is: " + greatest);
};