/*
Write a function that replaces non breaking white-spaces in a text with &nbsp;
*/

var text = "We are living in a yellow submarine. We don't have anything else.";
console.log(text);

jsConsole.writeLine(text + "<br />F12 to see result");

document.getElementById("submit").onclick = function(){console.log(replaceAll(text, ' ', ';nbsp&'));};

function replaceAll(text, toReplace, replaceWith) {
	return text.split(toReplace).join(replaceWith);
}
