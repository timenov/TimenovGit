//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

document.getElementById("submit").onclick = thirdBitValue;

function thirdBitValue() {
	var number = document.getElementById("input").value;

	jsConsole.writeLine("the third bit is: " + ((number >> 3) & 1));
};