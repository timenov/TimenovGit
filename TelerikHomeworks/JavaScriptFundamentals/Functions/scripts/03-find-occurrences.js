//Write a function that finds all the occurrences of word in a text
//	The search can case sensitive or case insensitive
//	Use function overloading

var text = "JavaScript is the programming language of the Web.<br />All modern HTML pages are using JavaScript.<br />JavaScript is easy to learn.<br />This tutorial will teach you JavaScript from basic to advanced."

jsConsole.writeLine(text + "<br />");

document.getElementById("submit").onclick = function() {jsConsole.writeLine("case sensitive counts: " + findOcc(text, document.getElementById("input").value) + 
																			"<br />case insensitive counts: " + findOcc(text, document.getElementById("input").value, true));};

function findOcc(text, word, isCaseSensitive) {
	var index = 0,
		counter = 0,
		content = text;

	if (isCaseSensitive) {
		content = content.toLowerCase();
		word = word.toLowerCase();
	}

	while (content.indexOf(word, index) > -1) {
		counter++;
		index = content.indexOf(word, index) + 1;
	}

	return counter;
};