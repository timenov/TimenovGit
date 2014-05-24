//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

jsConsole.writeLine("Enter two numbers separated by single space.");

document.getElementById("submit").onclick = exchangeValues;

function exchangeValues() {
	var numbers = document.getElementById("input").value.split(" ");

	var first = parseInt(numbers[0]),
		second = parseInt(numbers[1]),
		temp = first;

	if (first > second) {
		first = second;
		second = temp;
	};

	jsConsole.writeLine("first: " + first + "<br />second: " + second);
};