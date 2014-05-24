//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

jsConsole.writeLine("Enter two numbers separated by single space.<br />");

document.getElementById("submit").onclick = pointLocation;

function pointLocation() {
	var numbers = document.getElementById("input").value.split(" ");

	var x = parseInt(numbers[0]);
	var y = parseInt(numbers[1]);

	var isFromCircle = (x * x + y * y) < (4 * 4);

    var xIsNotFromRect = ((x < -1) || (x > 5));
    var yIsNotFromRect = ((y > 1) || (y < -1));
    var pointIsNotFromRect = xIsNotFromRect || yIsNotFromRect;

	jsConsole.writeLine("point is within circle: " + isFromCircle);
    jsConsole.writeLine("point is outside rectangle: " + pointIsNotFromRect);
};