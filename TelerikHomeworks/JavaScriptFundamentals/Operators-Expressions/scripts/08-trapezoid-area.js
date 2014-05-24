//Write an expression that calculates trapezoid's area by given sides a and b and height h.

jsConsole.writeLine("Enter three ('a', 'b' and 'h') numbers separated by single space.<br />");

document.getElementById("submit").onclick = trapezoidArea;

function trapezoidArea() {
	var numbers = document.getElementById("input").value.split(" ");
	var a = parseInt(numbers[0]);
	var b = parseInt(numbers[1]);
	var h = parseInt(numbers[2]);

	var area = (((a + b) / 2) * h);

	jsConsole.writeLine("the area is: " + area);
};