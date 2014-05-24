/*
Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags
*/

var text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
console.log(text);

jsConsole.writeLine('Press F12 to see the text.');

document.getElementById("submit").onclick = function(){ jsConsole.writeLine(extractText(text)); };

function extractText(text) {
	return text.replace(/\<\w+\>|\<\/\w+\>/g, '');
}
