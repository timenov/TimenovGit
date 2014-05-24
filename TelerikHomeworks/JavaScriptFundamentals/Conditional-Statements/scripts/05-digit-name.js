//Write script that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

document.getElementById("submit").onclick = digitName;

function digitName() {
	var number = document.getElementById("input").value;
	var digitInString;
	
	switch (number)
	{
		case "0": digitInString = "zero"; break;
		case "1": digitInString = "one"; break;
		case "2": digitInString = "two"; break;
		case "3": digitInString = "three"; break;
		case "4": digitInString = "four"; break;
		case "5": digitInString = "five"; break;
		case "6": digitInString = "six"; break;
		case "7": digitInString = "seven"; break;
		case "8": digitInString = "eight"; break;
		case "9": digitInString = "nine"; break;
		default: digitInString = "not a digit"; break;
	};

	jsConsole.writeLine(digitInString);
};