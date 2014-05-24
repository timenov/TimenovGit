//Write an expression that calculates rectangle’s area by given width and height.

jsConsole.writeLine("Enter two numbers separated by single space.");

document.getElementById("submit").onclick = calcArea;

function calcArea() {
	var numbers = document.getElementById("input").value.split(" ");

	jsConsole.writeLine("the area is: " + (numbers[0] * numbers[1]));
};