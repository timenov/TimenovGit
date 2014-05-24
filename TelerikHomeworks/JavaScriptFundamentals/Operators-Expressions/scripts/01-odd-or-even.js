//Write an expression that checks if given integer is odd or even.

document.getElementById("submit").onclick = evenOrOdd;

function evenOrOdd() {
	var number = document.getElementById("input").value;

	if ((number % 2) === 0) {
		jsConsole.writeLine("even");
	}else{
		jsConsole.writeLine("odd");
	};
};