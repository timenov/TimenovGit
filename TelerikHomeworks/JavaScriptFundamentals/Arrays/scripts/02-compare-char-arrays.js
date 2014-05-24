//Write a script that compares two char arrays lexicographically (letter by letter).

document.getElementById("submit").onclick = compareChars;

function compareChars() {
	var firstArr = ['a', 'b', 'c', 'd'],
		secondArr = ['v', 'a', 'w', 'd'],
		i;

	for (i = 0; i < firstArr.length; i++) {
		jsConsole.writeLine(firstArr[i] + (firstArr[i] > secondArr[i] ? " > " : firstArr[i] < secondArr[i] ? " < " : " = ") + secondArr[i]);
	};
};