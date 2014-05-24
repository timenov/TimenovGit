//Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

jsConsole.writeLine("Enter two numbers separated by single space.<br />");

document.getElementById("submit").onclick = pointLocation;

function pointLocation() {
	var numbers = document.getElementById("input").value.split(" ");

	var isFromCircle = (((numbers[0] * numbers[0]) + (numbers[1] * numbers[1])) < (5 * 5));

	jsConsole.writeLine("point is from circle: " + isFromCircle);
};