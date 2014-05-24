//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

document.getElementById("submit").onclick = divisionByBoth;

function divisionByBoth() {
	var number = document.getElementById("input").value;

	if ((number % 35) === 0) {
		jsConsole.writeLine("the number is divisible by 5 and 7 at same time");
	}else{
		jsConsole.writeLine("the number is not divisible by 5 and 7 at same time");
	};
};