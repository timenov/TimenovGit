//Write a script that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

jsConsole.writeLine("Enter three numbers separated by single space.");

document.getElementById("submit").onclick = toQuadraticEquation;

function toQuadraticEquation() {
	var numbers = document.getElementById("input").value.split(" ");

	var a = parseFloat(numbers[0]),
		b = parseFloat(numbers[1]),
		c = parseFloat(numbers[2]),
		disc = b * b - 4 * a * c,
        x1 = 0,
        x2 = 0;

        if ((a == 0 && b == 0) || (disc < 0)){
            jsConsole.writeLine("There is no roots.");
        }else if ((a == 0) || (disc == 0)){
            jsConsole.writeLine("There is one root.");
            // calculate root
            if(a == 0) {
                x1 = - c / b;
            }else{
                x1 = - b / 2 * a;
            }
            jsConsole.writeLine("x1 = x2 = " + x1);
        }else{
            jsConsole.writeLine("There is two roots.");
            // calculate roots
            if ((b == 0) && (c * a < 0)) {
                x1 = Math.sqrt(-c / a);
                x2 = (-Math.sqrt(-c / a));
            }else if (c == 0){
                x1 = 0;
                x2 = - b / a;
            }else{
                x1 = (-b - Math.sqrt(disc)) / 2 * a;
                x2 = (-b + Math.sqrt(disc)) / 2 * a;
            }
            jsConsole.writeLine("x1 = " + x1 + "<br />x2 = " + x2);
        }
};