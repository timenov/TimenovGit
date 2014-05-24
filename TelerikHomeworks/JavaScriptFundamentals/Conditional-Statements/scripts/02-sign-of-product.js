//Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

jsConsole.writeLine("Enter three numbers separated by single space.");

document.getElementById("submit").onclick = signOfProduct;

function signOfProduct() {
	var numbers = document.getElementById("input").value.split(" ");

	var first = parseFloat(numbers[0]),
		second = parseFloat(numbers[1]),
		third = parseFloat(numbers[2]);

	var isPositive = first > 0;
	isPositive ^= second > 0;
	isPositive ^= third > 0;

	if (first === 0 || second === 0 || third === 0) {
		jsConsole.writeLine("the product is zero");
	}else if (isPositive){
		jsConsole.writeLine("the product is positive");
	}else{
		jsConsole.writeLine("the product is negative");
	};
};