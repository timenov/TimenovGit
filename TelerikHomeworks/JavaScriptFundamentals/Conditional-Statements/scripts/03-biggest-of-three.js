//Write a script that finds the biggest of three integers using nested if statements.

jsConsole.writeLine("Enter three numbers separated by single space.");

document.getElementById("submit").onclick = biggetsNumber;

function biggetsNumber() {
	var numbers = document.getElementById("input").value.split(" ");

	var first = parseFloat(numbers[0]),
		second = parseFloat(numbers[1]),
		third = parseFloat(numbers[2]);


	if (first > second) {
		if (first > third) {
			jsConsole.writeLine("first number is biggets");
		}else if (first === third){
			jsConsole.writeLine("first and third numbers are biggets");
		}else{
			jsConsole.writeLine("third number is biggets");
		};
	}else if (first === second){
		if (first > third){
			jsConsole.writeLine("first and second numbers are biggets");
		}else if (first === third){
			jsConsole.writeLine("numbers are equal");
		}else{
			jsConsole.writeLine("third number is biggets");
		};
	}else{
		if (second > third) {
			jsConsole.writeLine("second number is biggets");
		}else if (second === third){
			jsConsole.writeLine("second and third numbers are biggets");
		}else{
			jsConsole.writeLine("third number is biggets");
		};
	};
};