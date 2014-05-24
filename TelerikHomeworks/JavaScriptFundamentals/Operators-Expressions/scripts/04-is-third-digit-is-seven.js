//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

document.getElementById("submit").onclick = thirdDigit;

function thirdDigit() {
	var number = document.getElementById("input").value;

	var index = number.length - 3;

	if (number[index] === "7") {
		jsConsole.writeLine("true");
	}else{
		jsConsole.writeLine("false");
	};
};